package com.longui.notebook.model;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Xml;

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

/**
 * Created by longui on 29/10/2015.
 */
public class SQLiteNoteRepository implements NoteRepository {
    static final String DATABASE_NAME = "notes.db";
    static final int DATABASE_VERSION = 1;
    static final String TABLE_NOTES = "notes";
    static final String COLUMN_ID = "id";
    static final String COLUMN_TITLE = "title";
    static final String COLUMN_TEXT = "text";
    static final String CREATE_NOTES_TABLE =
            "CREATE TABLE " + TABLE_NOTES + " (" + COLUMN_ID +
            " INTEGER PRIMARY KEY AUTOINCREMENT, " + COLUMN_TITLE +
            " TEXT," + COLUMN_TEXT + " TEXT" + ")";
    static final String DROP_NOTES_TABLE =
            "DROP TABLE IF EXISTS " + TABLE_NOTES;

    private SQLiteNotesHelper helper;

    public SQLiteNoteRepository(Context context) {
        helper = new SQLiteNotesHelper(context);
    }

    @Override
    public ArrayList<Note> getNotes() {
        ArrayList<Note> notes = new ArrayList<>();
        String query = "SELECT * FROM " + TABLE_NOTES;
        SQLiteDatabase db = helper.getReadableDatabase();
        Cursor cursor = db.rawQuery(query, null);

        if(cursor.moveToFirst()) {
            do {
                Note note = new Note();
                note.setId(cursor.getInt(
                        cursor.getColumnIndex(COLUMN_ID)));
                note.setTitle(cursor.getString(
                        cursor.getColumnIndex(COLUMN_TITLE)));
                note.setText(cursor.getString(
                        cursor.getColumnIndex(COLUMN_TEXT)));
                notes.add(note);
            } while(cursor.moveToNext());
        }
        cursor.close();
        db.close();

        return notes;
    }

    @Override
    public void addNote(Note note) {
        SQLiteDatabase db = helper.getWritableDatabase();
        ContentValues values = new ContentValues();
        values.put(COLUMN_TITLE, note.getTitle());
        values.put(COLUMN_TEXT, note.getText());

        db.insert(TABLE_NOTES, null, values);
        db.close();
    }

    @Override
    public void deleteNote(int noteId) {
        SQLiteDatabase db = helper.getWritableDatabase();

        db.delete(TABLE_NOTES, COLUMN_ID + " = ?",
                new String[] {String.valueOf(noteId)});
        db.close();
    }

    @Override
    public Note getNote(int noteId) {
        String query = "SELECT * FROM " + TABLE_NOTES + " WHERE " +
                COLUMN_ID + " = " + noteId;
        SQLiteDatabase db = helper.getReadableDatabase();
        Cursor cursor = db.rawQuery(query, null);

        Note note = new Note();
        if(cursor.moveToFirst()) {
            note.setId(cursor.getInt(
                    cursor.getColumnIndex(COLUMN_ID)));
            note.setTitle(cursor.getString(
                    cursor.getColumnIndex(COLUMN_TITLE)));
            note.setText(cursor.getString(
                    cursor.getColumnIndex(COLUMN_TEXT)));
        }
        cursor.close();
        db.close();

        return note;
    }

    class SQLiteNotesHelper extends SQLiteOpenHelper {
        public SQLiteNotesHelper(Context context) {
            super(context, DATABASE_NAME, null, DATABASE_VERSION);
        }

        @Override
        public void onCreate(SQLiteDatabase db) {
            db.execSQL(CREATE_NOTES_TABLE);
        }

        @Override
        public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
            db.execSQL(DROP_NOTES_TABLE);
            onCreate(db);
        }
    }
}
