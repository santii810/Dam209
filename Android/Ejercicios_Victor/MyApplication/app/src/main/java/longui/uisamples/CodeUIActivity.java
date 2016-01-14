package longui.uisamples;

import android.app.ActionBar;
import android.graphics.Color;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.ViewGroup;
import android.view.ViewGroup.LayoutParams;
import android.widget.Button;
import android.widget.RelativeLayout;

public class CodeUIActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        LayoutParams layoutParams =
                new RelativeLayout.LayoutParams(
                        LayoutParams.MATCH_PARENT,
                        LayoutParams.WRAP_CONTENT
                );

        Button button = new Button(this);
        button.setText("Púlsame");
        button.setBackgroundColor(Color.BLUE);
        button.setLayoutParams(layoutParams);

        LayoutParams layoutParams2 =
                new RelativeLayout.LayoutParams(
                        LayoutParams.MATCH_PARENT,
                        LayoutParams.MATCH_PARENT
                );

        RelativeLayout layout = new RelativeLayout(this);
        layout.addView(button);
        layout.setBackgroundColor(Color.YELLOW);

        this.addContentView(layout, layoutParams2);
    }
}
