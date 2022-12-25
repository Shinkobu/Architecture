import java.util.ArrayList;

// Отчёт. Представляет собой массив из записей
public class Report {

    ArrayList<Record> report = new ArrayList<>();

    @Override
    public String toString() {
        return "Report{" +
                "report=" + report +
                '}';
    }

    public void setReport(ArrayList<Record> report) {
        this.report = report;
    }

    public Report(ArrayList<Record> report) {
        this.report = report;
    }
}
