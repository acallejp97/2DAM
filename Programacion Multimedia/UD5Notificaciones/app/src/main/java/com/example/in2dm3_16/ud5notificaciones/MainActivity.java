package com.example.in2dm3_16.ud5notificaciones;

import android.app.Notification;
import android.app.NotificationChannel;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.Intent;
import android.support.v4.app.NotificationCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }


    public void onClickfin1(View view) {
        NotificationManager mNotificatioManager = (NotificationManager) getSystemService(NOTIFICATION_SERVICE);

        int icon = R.drawable.ic_launcher_foreground;
        CharSequence text = "Notificacion ticker text";
        long when = System.currentTimeMillis();

        NotificationCompat.Builder builder = new NotificationCompat.Builder(getApplicationContext(), NotificationChannel.DEFAULT_CHANNEL_ID);

        builder.setSmallIcon(icon);
        builder.setTicker(text);
        builder.setWhen(when);

        Intent intent = new Intent(this, SecondActivity.class);
        PendingIntent contentIntent = PendingIntent.getActivity(this, 0, intent, 0);

        builder.setContentTitle("Notification title");
        builder.setContentText("Notification text");
        builder.setContentIntent(contentIntent);
        builder.setAutoCancel(true);

        builder.setDefaults(NotificationCompat.DEFAULT_VIBRATE);
        builder.setDefaults(NotificationCompat.DEFAULT_SOUND);

        Notification notif = builder.build();

        final int HELLO_ID = 1;
        mNotificatioManager.notify(HELLO_ID, notif);
        finish();





    }

    public void onClickfin2(View view) {
    }
}
