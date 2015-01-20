using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Unnamed.LookupBox
{
    class SampleDataSet
    {
        public static DataSet createSampleDataSet()
        {
            List<String> dataList = getSampleDataList();

            DataSet ds = new System.Data.DataSet();
            foreach (string dataString in dataList)
            {
                String[] tokens = dataString.Split(new char[] { '\t' });
                if (ds.Tables.Contains(tokens[0]) == false)
                {
                    DataTable dt_new = ds.Tables.Add(tokens[0]);
                    dt_new.Columns.Add("id", typeof(string));
                    dt_new.Columns.Add("name", typeof(string));
                    dt_new.Columns.Add("category", typeof(string));
                }
                DataTable dt = ds.Tables[tokens[0]];
                DataRow dr = dt.Rows.Add();
                dr["id"] = tokens[1];
                dr["name"] = tokens[2];
                dr["category"] = tokens[3];
            }

            return ds;
        }

        private static List<String> getSampleDataList()
        {
            List<String> dataList = new List<string>();
            dataList.Add("Stocks\t13010\tKYOKUYO CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t13320\tNippon Suisan Kaisha,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t13330\tMaruha Nichiro Corporation\tAsia/Tokyo");
            dataList.Add("Stocks\t13520\tHOHSUI CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t13770\tSAKATA SEED CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t13790\tHOKUTO CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t14140\tSHO-BOND Holdings Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t14170\tMIRAIT Holdings Corporation\tAsia/Tokyo");
            dataList.Add("Stocks\t14190\tTama Home Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t14200\tSanyo Homes Corporation\tAsia/Tokyo");
            dataList.Add("Stocks\t15140\tSumiseki Holdings,Inc.\tAsia/Tokyo");
            dataList.Add("Stocks\t15150\tNittetsu Mining Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t15180\tMITSUI MATSUSHIMA CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t16050\tINPEX CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t16060\tJapan Drilling Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t16620\tJapan Petroleum Exploration Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t16630\tK&O Energy Group Inc.\tAsia/Tokyo");
            dataList.Add("Stocks\t17120\tDaiseki Eco.Solution Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t17190\tHAZAMA ANDO CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t17200\tTOKYU CONSTRUCTION CO., LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t17210\tCOMSYS Holdings Corporation\tAsia/Tokyo");
            dataList.Add("Stocks\t17220\tMISAWA HOMES CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t17620\tTAKAMATSU CONSTRUCTION GROUP CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t17660\tTOKEN CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t17800\tYAMAURA CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18010\tTAISEI CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18020\tOBAYASHI CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18030\tSHIMIZU CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18050\tTOBISHIMA CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18080\tHASEKO Corporation\tAsia/Tokyo");
            dataList.Add("Stocks\t18100\tMATSUI CONSTRUCTION CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t18110\tTHE ZENITAKA CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18120\tKAJIMA CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18130\tFudo Tetra Corporation\tAsia/Tokyo");
            dataList.Add("Stocks\t18140\tDAISUE CONSTRUCTION CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t18150\tTEKKEN CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18190\tNIPPON STEEL & SUMIKIN TEXENG.CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t18200\tNishimatsu Construction Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t18210\tSumitomo Mitsui Construction Co., Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t18220\tDAIHO CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18240\tMAEDA CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18260\tSata Construction Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t18270\tNAKANO CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18330\tOKUMURA CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18340\tDaiwa Odakyu Construction Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t18350\tTOTETSU KOGYO CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t18470\tICHIKEN Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t18520\tASANUMA CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18600\tTODA CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18610\tKumagai Gumi Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t18650\tAsunaro Aoki Construction Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t18660\tKITANO CONSTRUCTION CORP.,\tAsia/Tokyo");
            dataList.Add("Stocks\t18670\tUEKI CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18680\tMitsui Home Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t18700\tYAHAGI CONSTRUCTION CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t18710\tP.S. Mitsubishi Construction Co., Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t18730\tHIGASHI NIHON HOUSE CO.,LTD\tAsia/Tokyo");
            dataList.Add("Stocks\t18780\tDAITO TRUST CONSTRUCTION CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t18790\tSHINNIHON CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18810\tNIPPO CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18820\tTOA ROAD CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18830\tMAEDA ROAD CONSTRUCTION CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t18840\tTHE NIPPON ROAD CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t18850\tTOA CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18880\tWAKACHIKU CONSTRUCTION CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t18900\tTOYO CONSTRUCTION CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t18930\tPENTA-OCEAN CONSTRUCTION CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t18960\tOBAYASHI ROAD CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t18980\tSEIKITOKYU KOGYO CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t18990\tFUKUDA CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t19090\tNippon Dry-Chemical CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t19110\tSumitomo Forestry Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t19140\tJAPAN FOUNDATION ENGINEERING CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t19160\tNISSEI BUILD KOGYO CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t19190\tYAMADA SXL HOME CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t19210\tTOMOE CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t19240\tPanaHome Corporation\tAsia/Tokyo");
            dataList.Add("Stocks\t19250\tDAIWA HOUSE INDUSTRY CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t19260\tRAITO KOGYO CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t19280\tSekisui House,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t19290\tNITTOC CONSTRUCTION CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t19300\tHOKURIKU ELECTRICAL CONSTRUCTION CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t19340\tYURTEC CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t19370\tSeibu Electric Industry Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t19390\tYONDENKO CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t19410\tCHUDENKO CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t19420\tKANDENKO CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t19440\tKINDEN CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t19450\tTOKYO ENERGY & SYSTEMS INC.\tAsia/Tokyo");
            dataList.Add("Stocks\t19460\tTOENEC CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t19490\tSUMITOMO DENSETSU CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t19500\tNIPPON DENSETSU KOGYO CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t19510\tKYOWA EXEO CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t19520\tShin Nippon Air Technologies Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t19540\tNippon Koei Co.,Ltd.\tAsia/Tokyo");
            dataList.Add("Stocks\t19560\tNDS CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t19590\tKYUDENKO CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t19610\tSANKI ENGINEERING CO.,LTD.\tAsia/Tokyo");
            dataList.Add("Stocks\t19630\tJGC CORPORATION\tAsia/Tokyo");
            dataList.Add("Stocks\t19640\tChugai Ro Co.,Ltd.\tAsia/Tokyo");

            return dataList;
        }
    }
}
