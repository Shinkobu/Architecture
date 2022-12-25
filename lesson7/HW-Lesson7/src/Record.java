import java.util.ArrayList;

// Запись в отчёте. Представляет собой массив из строковых значений.
public class Record {

    ArrayList<String> record = new ArrayList<>();

    public Record(ArrayList<String> record) {
        this.record = record;
    }

    public ArrayList<String> getRecord() {
        return record;
    }

    public void setRecord(ArrayList<String> record) {
        this.record = record;
    }
}
