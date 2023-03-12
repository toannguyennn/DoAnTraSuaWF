using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0306211413
{
    public partial class Form1 : Form
    {
        string folderPath = @"D:\\TRASUA";
        public Form1()
        {
            InitializeComponent();

            DocFile();
            LoadImageList();
            LoadDSTraSua();
        }

        //Danh sách mã trà
        List<string> lstMaTra = new List<string>();

        //Danh sách tên trà
        List<string> lstTenTra = new List<string>();

        //Danh sách đơn giá
        List<long> lstDonGia = new List<long>();

        ///<summary>
        /// Đọc thư mục ảnh gán vào ImageList
        /// </summary>
        
        private void LoadImageList() 
        {
            //Lấy thông tin thư mục
            DirectoryInfo dir = new DirectoryInfo(folderPath);

            //Lấy tất cả các tập tin có phần mở rộng là jpg trong thư mục bên trên
            FileInfo[] listFile = dir.GetFiles("*.jpg");

            //Duyệt từng tập tin
            foreach(FileInfo fi in listFile)
            {
                // ... để thêm hình vào từ file trong thư mục
                // với tên file làm imageKey để phân biệt

                //Hình lớn
                imageListTraSuaLarge.Images.Add(fi.Name, Image.FromFile(fi.FullName));

                //Hình nhỏ
                imageListTraSuaSmall.Images.Add(fi.Name, Image.FromFile(fi.FullName));
            }    
        }

        private void XuLybtn(bool a) 
        {
            btnLuu.Enabled = !a;
            btnSua.Enabled = a;
            btnThem.Enabled = a;
            btnXoa.Enabled = a;
        }
        private void LoadDSTraSua()
        {
            // Làm mới ListView xoá hết các đối tượng cũ
            lvDSTraSua.Items.Clear();

            // Duyệt qua thông tin từng đối tượng trà sữa (mã trà, tên trà, đơn giá)
            for(int i = 0; i < lstMaTra.Count; i++)
            {
                //Mỗi Item có thêm hình ảnh từ ImageList, truy xuất bằng imageKey ( tên hình )
                ListViewItem lvi = new ListViewItem(lstMaTra[i], lstMaTra[i] + ".jpg");

                //Thêm thông tin vào đối tượng con
                lvi.SubItems.Add(lstTenTra[i]);
                lvi.SubItems.Add(lstDonGia[i].ToString());

                //Thêm đối tượng vào ListView
                lvDSTraSua.Items.Add(lvi);
            }
        }
        private void DocFile()
        {
            lstMaTra.Clear();
            lstTenTra.Clear();
            lstDonGia.Clear();

            string line;
            string[] splitter;

            StreamReader srd = new StreamReader(folderPath + @"\DSTraSua.txt");

            while((line = srd.ReadLine()) != null)
            {
                splitter = line.Split(',');

                lstMaTra.Add(splitter[0]);
                lstTenTra.Add(splitter[1]);
                lstDonGia.Add(long.Parse(splitter[2]));
            }

            srd.Close();
            srd.Dispose();
            System.GC.Collect();
        }

        private void lvDSTraSua_SelectedIndexChanged(object sender, EventArgs e)
        {
            // chỉ xử lý khi người dùng chọn đối tượng trong ListView ( SL người chọn > 0)
            if(lvDSTraSua.SelectedItems.Count > 0)
            {
                //Lấy đối tượng được chọn đầu tiên hiển thị thông tin
                txtMaTra.Text = lvDSTraSua.SelectedItems[0].Text;
                txtTenTra.Text = lvDSTraSua.SelectedItems[0].SubItems[1].Text;
                txtSoTien.Text = lvDSTraSua.SelectedItems[0].SubItems[2].Text;

                //Kiểm tra có hình ảnh trong thư mục hay không
                if(File.Exists(folderPath + "/" + txtMaTra.Text + ".jpg")) 
                {
                    //chuyển hình ảnh thành dữ liệu byte
                    byte[] byteHA = File.ReadAllBytes(folderPath + "/" + txtMaTra.Text + ".jpg");
                    //chuyển dữ liệu thành đối tượng MemoryStream cho việc chuyển dữ liệu
                    MemoryStream mos = new MemoryStream(byteHA);
                    //Tạo đối tượng Image từ MemoryStream
                    pbHinh.Image = Image.FromStream(mos);
                }
                else
                {
                    pbHinh.Image = null;
                }
            }

        }

        private void rdbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLargeIcon.Checked) lvDSTraSua.View = View.LargeIcon;
        }

        private void rdbDetail_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDetail.Checked) lvDSTraSua.View = View.Details;
        }

        private void rdbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSmallIcon.Checked) lvDSTraSua.View = View.SmallIcon;
        }

        private void rdbList_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbList.Checked) lvDSTraSua.View = View.List;
        }

        private void rdbTile_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTile.Checked) lvDSTraSua.View = View.Tile;
        }

        ///<summary>>
        ///Ghi dữ liệu ra tập tin nguồn
        ///</summary>
        
        private void WriteFile()
        {
            using (StreamWriter sw = new StreamWriter(folderPath + @"\DSTraSua.txt", false))
            {
                for(int i = 0; i < lstMaTra.Count; i++)
                {
                    //Định dạng dữ liệu thành từng dòng
                    string line = string.Format("{0},{1},{2}", lstMaTra[i], lstTenTra[i], lstDonGia[i]);
                    sw.WriteLine(line);
                }
                sw.Close(); 
                sw.Dispose(); 
                System.GC.Collect();
            }
        }

        private void pbHinh_Click(object sender, EventArgs e)
        {
            //Tạo đối tượng đọc hình ảnh
            Stream myStream = null;
            //Mặc định OpenFileDialog mở ổ đĩa 
            ofdFile.InitialDirectory = @"C:\\";
            //Lọc những loại tập tin có thể mở được 
            ofdFile.Filter = "Image files (*.jpg,*.jpeg,*.jpe,*.jfif,,*.png) | *.jpg;*.jpeg;*.jpe;*.jfif;*.png";
            ofdFile.FilterIndex= 2;
            ofdFile.RestoreDirectory= true;

            //Hiển thị hộp thoại
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //tập tin tồn tại
                    if((myStream = ofdFile.OpenFile()) != null)
                    {
                        //Đọc tập tập tin và hiển thị PictureBox
                        using (myStream)
                        {
                            pbHinh.Image = Image.FromStream(myStream);
                        }
                    }
                }
                catch(Exception ex)  
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                myStream.Close();
                myStream.Dispose();
                System.GC.Collect();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            

            lstMaTra.Add(txtMaTra.Text);
            lstTenTra.Add(txtTenTra.Text);
            lstDonGia.Add(Convert.ToInt64(txtSoTien.Text));

            WriteFile();

            using(MemoryStream memory = new MemoryStream())
            {
                using (FileStream fs = new FileStream(folderPath + "/" + txtMaTra.Text + ".jpg", FileMode.Create, FileAccess.ReadWrite))
                {
                    byte[] bytes = ConvertImageToByteArray(pbHinh.Image);
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
            DocFile();
            LoadImageList();
            LoadDSTraSua();
            XuLybtn(true);
        }

        ///<summary>
        ///Chuyển đối tượng Image sang mảng byte chi việc lưu hình ảnh
        /// </summary>
        public byte[] ConvertImageToByteArray(Image imageToConvert)
        {
            using (var ms = new MemoryStream())
            {
                //chuyển image sang kiểu bitmap
                Bitmap bmp = new Bitmap(imageToConvert);

                //lưu bitmap thành MemoryStream cho việc lưu trữ hình ảnh
                bmp.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XuLybtn(false);
            lstMaTra.Sort();

            //lấy value cuối
            //cắt chuỗi 3 ký tự cuối
            //chuyển về số
            //+1
            // TSxxx

            int index = Convert.ToInt32(lstMaTra.Last<string>().Substring(2, 3));

            txtMaTra.Text = string.Format("TS{0}", (index + 1).ToString("000"));

            txtTenTra.Text = string.Empty;
            txtSoTien.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XuLybtn(true);
        }
    }
}
