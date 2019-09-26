package com.example.sajidahmed.autocompletetextbox;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.MultiAutoCompleteTextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    private AutoCompleteTextView autoComplete;
    private MultiAutoCompleteTextView multiAutoComplete;
    private ArrayAdapter<String> stringArrayAdapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        String[] countries = getResources().getStringArray(R.array.Countries);

        stringArrayAdapter = new ArrayAdapter<String>(this, android.R.layout.simple_expandable_list_item_1, countries);

        autoComplete = (AutoCompleteTextView)findViewById(R.id.autocomplete);
        multiAutoComplete = (MultiAutoCompleteTextView)findViewById(R.id.multiAutoComplete);

        autoComplete.setAdapter(stringArrayAdapter);
        multiAutoComplete.setAdapter(stringArrayAdapter);

        autoComplete.setThreshold(1);
        multiAutoComplete.setThreshold(2);

        multiAutoComplete.setTokenizer(new MultiAutoCompleteTextView.CommaTokenizer());

        /*multiAutoComplete.setOnClickListener((parent, view, position, id) -> {
            Toast.makeText(getBaseContext(), "MultiAutoComplete: " +
                                "you added Country " + parent.getItemAtPosition(position),
                                Toast.LENGTH_LONG).show();
        });*/
    }
}
