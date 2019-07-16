package com.example.in2dm3_07.aplicacionfinal.LlenarListView;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import com.example.in2dm3_07.aplicacionfinal.R;

import org.w3c.dom.Text;

import java.util.ArrayList;

/**
 * Created by Asier on 24/01/2018.
 */

public class tvAdapter extends ArrayAdapter<TextBoxes> {

    private TextView tvNombre, tvID;
    private TextBoxes textBoxes;

    public tvAdapter(Context context, ArrayList<TextBoxes> textBoxes) {
        super(context, 0, textBoxes);
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        textBoxes=getItem(position);
        if (convertView == null) {
            convertView = LayoutInflater.from(getContext()).inflate(R.layout.simple_list_item_1, parent, false);
        }
        tvNombre = convertView.findViewById(R.id.tvNombreApellido);
        tvID = convertView.findViewById(R.id.tvID);
        tvNombre.setText(textBoxes.ID);
        tvID.setText(textBoxes.NombreApellido);

        return convertView;
    }
}