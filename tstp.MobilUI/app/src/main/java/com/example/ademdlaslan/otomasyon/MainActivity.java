package com.example.ademdlaslan.otomasyon;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }




    public void tks (View view)
    {
        Intent intent=new Intent(this,TeknikServisActivity.class);
        startActivity(intent);
    }
    public void ypc(View view)
    {

        Intent intent=new Intent(this,YedekParcaActivity.class);
        startActivity(intent);
    }

    public void web (View view)
    {
        Intent intent=new Intent(this,WebSayfasiActivity.class);
        startActivity(intent);
    }
}
