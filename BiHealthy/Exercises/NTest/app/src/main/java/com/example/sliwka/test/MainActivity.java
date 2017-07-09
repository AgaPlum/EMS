package com.example.sliwka.test;

import android.content.Intent;
import android.os.Bundle;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.View;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
public int a;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        final TextView firstTextView = (TextView) findViewById(R.id.textView);
        //Button firstbutton =(Button)findViewById(R.id.firstbutton);

        /*FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener()
         */
        //firstbutton.setOnClickListener(new View.OnClickListener(){


    }

    public void buttonClick(View view) {
              /*  Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
            */
        int i = selectItem(view);
        Intent startNewAc = new Intent();
        if (i == 1) {
            startNewAc = new Intent(this, NewWin.class);
            //firstTextView.setText("You clicked")
        }
        if (i == 2) {
            startNewAc = new Intent(this, NewWin2.class);
            //firstTextView.setText("You clicked")
        }
        if (i == 3) {
            startNewAc = new Intent(this, NewWin3.class);
            //firstTextView.setText("You clicked")
        }
        if (i == 4) {
            startNewAc = new Intent(this, DisplayMessageActivity.class);
            //firstTextView.setText("You clicked")
        }
        if (i == 5) {
            startNewAc = new Intent(this, NewWin5.class);
            //firstTextView.setText("You clicked")
        }

        startActivity(startNewAc);
    }

    public int selectItem(View view) {
        boolean checked = ((CheckBox) view).isChecked();
        //int a=0;
        switch (view.getId()) {
            case R.id.checkBox:
                if (checked) {
                    a= 1;
                } else {
                }
                break;
            case R.id.checkBox2:
                if (checked) {
                    a= 2;
                } else {
                }
                break;
            case R.id.checkBox3:
                if (checked) {
                    a= 3;
                } else {
                }
                break;
            case R.id.checkBox4:
                if (checked) {
                    a= 4;
                } else {
                }
                break;
            case R.id.checkBox5:
                if (checked) {
                    a= 5;
                } else {
                }
                break;
        }
        return a;
    }
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }
}
