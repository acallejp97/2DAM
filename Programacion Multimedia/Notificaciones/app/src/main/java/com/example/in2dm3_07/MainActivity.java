package com.example.in2dm3_07;

import android.app.Notification;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.app.NotificationCompat;

import com.example.in2dm3_15.notificaciones.R;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    protected void onClick1(){
        //1. Conseguir NotificationManager
        NotificationManager mNotificationManager=(NotificationManager) getSystemService(NOTIFICATION_SERVICE);

        //2.Crear la notificación
        int icon=R.drawable.android;
        CharSequence text="Notification ticket text";
        long when =System.currentTimeMillis();

        NotificationCompat.Builder builder= new NotificationCompat.Builder(getApplicationContext());

        builder.setSmallIcon(icon);
        builder.setTicker(text);
        builder.setWhen(when);

        Intent intent= new Intent (this, SecondActivity.class);
        PendingIntent contentIntent= PendingIntent.getActivity(this,0,intent,0);

        builder.setContentTitle("Notification title");
        builder.setContentText("Notification text");
        builder.setContentIntent(contentIntent);
        builder.setAutoCancel(true);

        builder.setDefaults(NotificationCompat.DEFAULT_VIBRATE);
        builder.setDefaults(NotificationCompat.DEFAULT_SOUND);

        Notification notif =builder.build();

        final int HELLO_ID=1;
        mNotificationManager.notify(HELLO_ID, notif);
        finish();
       // int icon=R.mipmap.ic_launcher;


    }
}
