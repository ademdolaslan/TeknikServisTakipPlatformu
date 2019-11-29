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


public class TeknikServisActivity extends Activity {
    TextView textview;
    NodeList nodelist;
    ProgressDialog pDialog;
    final String URL = "http://172.20.10.5/api/default/tks";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_teknik_servis);
        textview=(TextView) findViewById(R.id.text);
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
            pDialog = new ProgressDialog(TeknikServisActivity.this);
            // Set progressbar title
            pDialog.setTitle("Teknik Servis Durum Bilgileri Yükleniyor");
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
                nodelist = doc.getElementsByTagName("view_teknik_servis");

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
                    textview.setText(textview.getText() + "Müşetri Adı  : "
                            + getNode("musteri_adi", eElement) + "\n");
                    textview.setText(textview.getText() + "Müşteri Soyadı : "
                            + getNode("musteri_soyadi", eElement) + "\n");
                    textview.setText(textview.getText() + "Müşteri Telefonu : "
                            + getNode("musteri_telefon", eElement) + "\n");
                    textview.setText(textview.getText() + "Cihaz Bilgisi  : "
                            + getNode("ariza_cihaz", eElement) + "\n");
                    textview.setText(textview.getText() + "Arıza Tanımı : "
                            + getNode("ariza_tanim", eElement) + "\n");
                    textview.setText(textview.getText() + "Uygulanan Çözüm : "
                            + getNode("ariza_cozum", eElement) + "\n");
                    textview.setText(textview.getText() + "İlgilenen Personel Adı : "
                            + getNode("personel_adi", eElement) + "\n");
                    textview.setText(textview.getText() + "İlgilenen Personel Soyadı : "
                            + getNode("personel_soyadi", eElement) + "\n");
                    textview.setText(textview.getText() + "_____________________________________________"+"\n");
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
