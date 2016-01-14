package com.longui.notebook.model;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Xml;

import com.parse.Parse;
import com.parse.ParseException;
import com.parse.ParseObject;
import com.parse.ParseQuery;

import org.xmlpull.v1.XmlPullParser;
import org.xmlpull.v1.XmlPullParserException;
import org.xmlpull.v1.XmlPullParserFactory;
import org.xmlpull.v1.XmlSerializer;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by longui on 29/10/2015.
 */
public class ParseNoteRepository implements NoteRepository {
    public ParseNoteRepository(Context context) {
        // Enable Local Datastore.
        Parse.enableLocalDatastore(context);

        Parse.initialize(context,
                "GhNExCRfhFAUd8gLETIQQJ9pWlpk4C7Ua7Pkf7SH",
                "LCvloWIOHshahVbKJwwcl10o8zLNj3cUaigTdpaM");
    }

    @Override
    public ArrayList<Note> getNotes() {
        ArrayList<Note> notes = new ArrayList<>();

        ParseQuery<ParseObject> query = ParseQuery.getQuery("Note");
        try {
            List<ParseObject> result = query.find();

            for (ParseObject object: result) {
                Note note = new Note();
                note.setId(object.getObjectId());
                note.setTitle(object.getString("title"));
                note.setText(object.getString("text"));
                notes.add(note);
            }
        } catch (ParseException e) {
            e.printStackTrace();
        }

        return notes;
    }

    @Override
    public void addNote(Note note) {
        ParseObject parseNote = new ParseObject("Note");
        parseNote.put("title", note.getTitle());
        parseNote.put("text", note.getText());
        parseNote.saveInBackground();
    }

    @Override
    public void deleteNote(String noteId) {
        ParseQuery<ParseObject> query = ParseQuery.getQuery("Note");
        try {
            query.whereEqualTo("objectId", noteId);
            List<ParseObject> result = query.find();

            if(result.size() > 0) {
                result.get(0).delete();
            }
        } catch (ParseException e) {
            e.printStackTrace();
        }
    }

    @Override
    public Note getNote(String noteId) {
        Note note = new Note();

        ParseQuery<ParseObject> query = ParseQuery.getQuery("Note");
        try {
            query.whereEqualTo("objectId", noteId);
            List<ParseObject> result = query.find();

            if(result.size() > 0) {
                note.setId(result.get(0).getObjectId());
                note.setTitle(result.get(0).getString("title"));
                note.setText(result.get(0).getString("text"));
            }
        } catch (ParseException e) {
            e.printStackTrace();
        }

        return note;
    }
}
