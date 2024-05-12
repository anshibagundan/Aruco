package jp.ac.ritsumei.ise.phy.exp2.is0674hk.dementia_quiz;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.TextView;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class game extends AppCompatActivity {

    private ApiService apiService;
    private TextView act_text;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_game);

        // ApiServiceインスタンスを取得
        apiService = ApiClient.getApiService();

        act_text=findViewById(R.id.act_text);

        act_setText();
        quiz_setText();
    }

    public void act_setText(){
        apiService.getAct_select().enqueue(new Callback<List<Act_select>>() {
            @Override
            public void onResponse(Call<List<Act_select>> call, Response<List<Act_select>> response) {
                int act_diff = 0;
                if (response.isSuccessful() && response.body() != null) {
                    Log.d("act_diff", String.valueOf(response.body().get(0)));
                    act_diff = response.body().get(0).getSelect_diff();
                    act_text.setText(String.valueOf(act_diff));
                    Log.d("act_diff", String.valueOf(act_diff));

                }else{
                    Log.e("act_diff", "fail ");
                }
            }


            @Override
            public void onFailure(Call<List<Act_select>> call, Throwable t) {
                Log.e("act_diff", "onFailure ");
            }
        });
    }
    public void quiz_setText(){
        apiService.getQuiz_select().enqueue(new Callback<List<Quiz_select>>() {
            @Override
            public void onResponse(Call<List<Quiz_select>> call, Response<List<Quiz_select>> response) {
                int quiz_diff = 0;
                if (response.isSuccessful() && response.body() != null) {
                    Log.d("act_diff", String.valueOf(response.body().get(0)));
                    quiz_diff = response.body().get(0).getSelect_diff();
                    act_text.setText(String.valueOf(quiz_diff));
                    Log.d("act_diff", String.valueOf(quiz_diff));

                }else{
                    Log.e("act_diff", "fail ");
                }
            }

            @Override
            public void onFailure(Call<List<Quiz_select>> call, Throwable t) {

            }
        });

    }
}