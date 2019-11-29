package com.example.ademdlaslan.otomasyon;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.webkit.WebView;

public class WebSayfasiActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_web_sayfasi);

        WebView webview = (WebView) findViewById(R.id.webview);

        webview.getSettings().setJavaScriptEnabled(true);
        webview.loadUrl("https://ademdolaslan.wordpress.com/");

    }
}
