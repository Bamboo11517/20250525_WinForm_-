namespace _20250525_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                //DB接続用クラスを用意
                SQLiteUtil sqlite = new SQLiteUtil();

                //ログイン認証実施
                if (sqlite.Login(this.userid.Text, this.txtPass.Text) == true)
                {
                    //商品購入画面を表示
                    Form order = new ORDER();
                    order.ShowDialog();
                }
                else
                {
                    //エラーメッセージ表示
                    ErrorUtil.ShowError(MessageResource.ERR009);
                }
            }
            catch (Exception ex)
            {
                //例外エラー処理
                ErrorUtil.ExceptionError(ex);
            }
        }

        /// <summary>
        ///    未入力項目監視
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEmptyCheck_Tick(object sender, EventArgs e)
        {
            try
            {
                //未入力項目が存在する場合はログインボタンを無効化
                if (string.IsNullOrEmpty(this.userid.Text) == true || string.IsNullOrEmpty(this.txtPass.Text) == true)
                {
                    this.login.Enabled = false;
                }
                else
                {
                    this.login.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                //例外エラー処理
                ErrorUtil.ExceptionError(ex);
            }
        }

        /// <summary>
        ///    数値入力制御
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericalInputControl(object sender, KeyPressEventArgs e)
        {
            //バックスペース、Deleteキーが押された時は入力有効
            if (e.KeyChar.Equals('\b') == true)
            {
                return;
            }

            //数値0～9以外が押された時は入力無効
            if (e.KeyChar < '0' == true || '9' < e.KeyChar == true)
            {
                e.Handled = true;
            }
        }



        private void txtU(object sender, KeyPressEventArgs e)
        {

        }

        private void pass_Click(object sender, EventArgs e)
        {

        }
    }
}
