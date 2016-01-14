package longui.greetings;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.TextView;

public class GreetingsActivity extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_greetings);

        TextView textView = (TextView)findViewById(R.id.greetingsTextView);
        textView.setText(getString(R.string.greeting_message,
                getIntent().getStringExtra("name")));
    }
}
