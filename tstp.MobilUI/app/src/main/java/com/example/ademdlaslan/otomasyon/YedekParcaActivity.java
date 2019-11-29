package com.example.ademdlaslan.otomasyon;

import android.app.Activity;
import android.app.ProgressDialog;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.widget.TextView;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.xml.sax.InputSource;

import java.net.URL;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;


public class YedekParcaActivity extends Activity {
    TextView textview;
    NodeList nodelist;
    ProgressDialog pDialog;
    final String URL = "http://172.20.10.5/api/default/ypc";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_yedek_parca);
        textview=(TextView) findViewById(R.id.tv);
        try
        {
            new DownloadXML().execute(URL);
        }
        catch (Exception e)
        {
            Log.e("Hata", e.getMessage());
            e.printStackTrace();
        }
    }
    private class DownloadXML extends AsyncTask<String, Void, Void> {
        @Override
        protected void onPreExecute() {
            super.onPreExecute();
            // Create a progressbar
            pDialog = new ProgressDialog(YedekParcaActivity.this);
            // Set progressbar title
            pDialog.setTitle("Yedek parça Bilgileri Yükleniyor");
            // Set progressbar message
            pDialog.setMessage("Loading...");
            pDialog.setIndeterminate(false);
            // Show progressbar
            pDialog.show();
        }
        @Override
        protected Void doInBackground(String... Url) {
            try {
                URL url = new URL(Url[0]);
                DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
                DocumentBuilder db = dbf.newDocumentBuilder();
                // Download the XML file
                Document doc = db.parse(new InputSource(url.openStream()));
                doc.getDocumentElement().normalize();
                // Locate the Tag Name
                nodelist = doc.getElementsByTagName("view_yedek_parca");
            } catch (Exception e) {
                Log.e("Hata", e.getMessage());
                e.printStackTrace();
            }
            return null;
        }
        @Override
        protected void onPostExecute(Void args) {
            for (int temp = 0; temp < nodelist.getLength(); temp++) {
                Node nNode = nodelist.item(temp);
                if (nNode.getNodeType() == Node.ELEMENT_NODE) {
                    Element eElement = (Element) nNode;
                    textview.setText(textview.getText() + "Parça İsmi  : "
                            + getNode("parca_ismi", eElement) + "\n");
                    textview.setText(textview.getText() + "parça Markası : "
                            + getNode("parca_marka", eElement) + "\n");
                    textview.setText(textview.getText() + "Parça Modeli : "
                            + getNode("parca_model", eElement) + "\n");
                    textview.setText(textview.getText() + "Parçanın Türü  : "
                            + getNode("parca_tur", eElement) + "\n");
                    textview.setText(textview.getText() + "Stok Adeti : "
                            + getNode("parca_stok", eElement) + "\n");
                    textview.setText(textview.getText() + "Parça Fiyatı : "
                            + getNode("parca_fiyat", eElement) +"\n");
                    textview.setText(textview.getText() + "_______________________________________________________"+"\n");
                }
            }

            pDialog.dismiss();
        }
    }
    private static String getNode(String sTag, Element eElement) {
        NodeList nlList = eElement.getElementsByTagName(sTag).item(0)
                .getChildNodes();
        Node nValue = (Node) nlList.item(0);
        return nValue.getNodeValue();
    }
}
