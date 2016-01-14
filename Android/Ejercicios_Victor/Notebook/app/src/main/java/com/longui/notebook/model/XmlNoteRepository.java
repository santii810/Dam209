package com.longui.notebook.model;

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
public class XmlNoteRepository implements NoteRepository {
    private static final String FILE_NAME = "notes.xml";
    private File filePath;
    private ArrayList<Note> notes;
    private int currentId;

    public XmlNoteRepository(File filePath) {
        this.filePath = filePath;

        loadData();
    }

    @Override
    public ArrayList<Note> getNotes() {
        return notes;
    }

    @Override
    public void addNote(Note note) {
        note.setId(currentId++);
        notes.add(note);

        saveData();
    }

    @Override
    public void deleteNote(int noteId) {
        notes.remove(getNote(noteId));
        saveData();
    }

    @Override
    public Note getNote(int noteId) {
        for (Note note : notes) {
            if(note.getId() == noteId) {
                return note;
            }
        }

        return null;
    }

    private void loadData() {
        notes = new ArrayList<>();
        currentId = 1;

        XmlPullParserFactory factory = null;
        try {
            factory = XmlPullParserFactory.newInstance();
            factory.setNamespaceAware(true);
            XmlPullParser parser = factory.newPullParser();

            FileInputStream fis =
                    new FileInputStream(filePath + "/" + FILE_NAME);
            InputStreamReader isr = new InputStreamReader(fis);

            parser.setInput(isr);
            int eventType = parser.getEventType();
            Note note = null;
            while(eventType != XmlPullParser.END_DOCUMENT) {
                if(eventType == XmlPullParser.START_TAG) {
                    if(parser.getName().equals("note")) {
                        note = new Note();
                        note.setId(Integer.parseInt(parser.getAttributeValue(0)));
                    }
                    else if(parser.getName().equals("title")) {
                        note.setTitle(parser.nextText());
                    }
                    else if(parser.getName().equals("text")) {
                        note.setText(parser.nextText());
                    }
                } else if (eventType == XmlPullParser.END_TAG) {
                    if(parser.getName().equals("note")) {
                        notes.add(note);
                        currentId = note.getId() + 1;
                    }
                } else if (eventType == XmlPullParser.TEXT) {

                }
                eventType = parser.next();
            }

        } catch (XmlPullParserException e) {
            e.printStackTrace();
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private void saveData() {
        XmlSerializer xmlSerializer = Xml.newSerializer();

        FileOutputStream fos = null;
        try {
            fos = new FileOutputStream(filePath + "/" + FILE_NAME);
            OutputStreamWriter osw = new OutputStreamWriter(fos);
            xmlSerializer.setOutput(osw);

            xmlSerializer.startDocument("UTF-8", true);
            xmlSerializer.setFeature(
                    "http://xmlpull.org/v1/doc/features.html#indent-output", true);

            xmlSerializer.startTag("", "notes");
            for (Note note : notes) {
                xmlSerializer.startTag("", "note");
                xmlSerializer.attribute("", "id",
                        String.valueOf(note.getId()));
                xmlSerializer.startTag("", "title");
                xmlSerializer.text(note.getTitle());
                xmlSerializer.endTag("", "title");
                xmlSerializer.startTag("", "text");
                xmlSerializer.text(note.getText());
                xmlSerializer.endTag("", "text");
                xmlSerializer.endTag("", "note");
            }
            xmlSerializer.endTag("", "notes");

            xmlSerializer.endDocument();
            osw.close();
            fos.close();

        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
