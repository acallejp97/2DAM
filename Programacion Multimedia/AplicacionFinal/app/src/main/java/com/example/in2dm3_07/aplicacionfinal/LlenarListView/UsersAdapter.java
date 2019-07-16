package com.example.in2dm3_07.aplicacionfinal.LlenarListView;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import com.example.in2dm3_07.aplicacionfinal.LlenarListView.User;
import com.example.in2dm3_07.aplicacionfinal.R;

import java.util.ArrayList;

/**
 * Created by Asier on 24/01/2018.
 */

public class UsersAdapter extends ArrayAdapter<User> {
    public UsersAdapter(Context context, ArrayList<User> users) {
        super(context, 0, users);
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        // Get the data item for this position
        User user = getItem(position);
        // Check if an existing view is being reused, otherwise inflate the view
        if (convertView == null) {
            convertView = LayoutInflater.from(getContext()).inflate(R.layout.simple_list_item_1, parent, false);
        }
        // Lookup view for data population
        TextView tvName = (TextView) convertView.findViewById(R.id.tvName);
        TextView tvID = (TextView) convertView.findViewById(R.id.tvID);
        // Populate the data into the template view using the data object
        tvName.setText(user.name);
        tvID.setText(user.hometown);
        // Return the completed view to render on screen
        return convertView;
    }
}