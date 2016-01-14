package longui.uisamples;

import android.graphics.Color;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.RelativeLayout;

public class MenuActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_menu, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();
        RelativeLayout layout =
                (RelativeLayout)findViewById(R.id.layout);

        //noinspection SimplifiableIfStatement
        if (id == R.id.redMenuItem) {
            layout.setBackgroundColor(Color.RED);
            return true;
        }
        else if(id == R.id.blackMenuItem) {
            layout.setBackgroundColor(Color.BLACK);
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}
