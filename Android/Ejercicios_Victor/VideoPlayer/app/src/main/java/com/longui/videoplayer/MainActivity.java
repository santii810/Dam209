package com.longui.videoplayer;

import android.content.Intent;
import android.widget.MediaController;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.VideoView;

public class MainActivity extends AppCompatActivity {
    private static final int REQUEST_CODE = 1;

    VideoView videoView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        videoView = (VideoView)findViewById(R.id.videoView);

        MediaController mediaController = new MediaController(this);
        mediaController.setAnchorView(videoView);
        videoView.setMediaController(mediaController);

//        Uri uri = Uri.parse("android.resource://" +
//            "com.longui.videoplayer/" + R.raw.video);

        Intent intent = new Intent(Intent.ACTION_GET_CONTENT);
        intent.setType("video/*");

        startActivityForResult(intent, REQUEST_CODE);
    }

    @Override
    protected void onActivityResult(
            int requestCode, int resultCode, Intent data) {
        if(requestCode == REQUEST_CODE && resultCode == RESULT_OK) {
            Uri uri = data.getData();
            videoView.setVideoURI(uri);
            videoView.start();
        }
    }
}
