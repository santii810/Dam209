package com.longui.fragments;


import android.graphics.Color;
import android.os.Bundle;
import android.app.Fragment;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.RelativeLayout;
import android.widget.TextView;


/**
 * A simple {@link Fragment} subclass.
 */
public class PinkFragment extends Fragment {


    public PinkFragment() {
        // Required empty public constructor
    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        return inflater.inflate(R.layout.fragment_pink, container, false);
    }

    @Override
    public void onStart() {
        super.onStart();
        Button button = (Button)getActivity().findViewById(R.id.button);
        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                TextView textView = (TextView)getActivity().
                        findViewById(R.id.textViewYF);
                //RelativeLayout layout = (RelativeLayout)getActivity().
                //        findViewById(R.id.yellowLayout);

                //layout.setBackgroundColor(Color.argb(255, 255, 16, 179));
                textView.setText("Pinkizado!!!");
            }
        });
    }
}
