using System.ComponentModel.DataAnnotations.Schema;

namespace Core.DomainModels
{
	[Table("SCCLSFP")]
	public class Conviction : BaseEntity
	{
		[Column("CLSYAR")]
		public int SBCourtYear { get; set; }

		[Column("CLSOS#")]
		public int SBCourtYearSequece { get; set; }

		[Column("CLLIN#")]
		public int LineNumber { get; set; }

		[Column("CLVIOCD")]
		public string ViolationCode { get; set; }

		[Column("CLFLMSD")]
		public string Felony { get; set; }

		[Column("CLJURIS")]
		public string JurisidictionCode { get; set; }

		[Column("CLTITLE")]
		public string ClassificationTitle { get; set; }

		[Column("CLKYWRD")]
		public string Keyword { get; set; }

		[Column("CLCBCONF")]
		public bool ConferenceItem { get; set; }

		[Column("CLCLSCD")]
		public string ClassificationCode { get; set; }

		[Column("CLCLSYR")]
		public int ClassificationYear { get; set; }

		[Column("CLCSNAM")]
		public string CaseName { get; set; }

		[Column("CLDCNBR")]
		public string CaseNumber { get; set; }

		[Column("CLOLNBR")]
		public string OldCaseNumber { get; set; }

		[Column("CLOLLN#")]
		public int LineNumber2 { get; set; }

		[Column("CLCMNT80")]
		public string Comment { get; set; }

		[Column("CL@LOG")]
		public int LogDate { get; set; }

		[Column("CLLOGTM")]
		public int LogTime { get; set; }

		[Column("CLLOGID")]
		public string LogUserId { get; set; }

		[Column("CLLOGXD")]
		public string LogExe_Dll { get; set; }

		[Column("CLLOGFP")]
		public string LogForm_Pgm { get; set; }

		public override void UpdateValueFrom(BaseEntity source)
		{
			var sourceEntity = source as Conviction;
			SBCourtYear = sourceEntity.SBCourtYear;
			SBCourtYearSequece = sourceEntity.SBCourtYearSequece;
			LineNumber = sourceEntity.LineNumber;
			ViolationCode = sourceEntity.ViolationCode;
			Felony = sourceEntity.Felony;
			JurisidictionCode = sourceEntity.JurisidictionCode;
			ClassificationTitle = sourceEntity.ClassificationTitle;
			Keyword = sourceEntity.Keyword;
			ConferenceItem = sourceEntity.ConferenceItem;
			ClassificationCode = sourceEntity.ClassificationCode;
			ClassificationYear = sourceEntity.ClassificationYear;
			CaseName = sourceEntity.CaseName;
			CaseNumber = sourceEntity.CaseNumber;
			OldCaseNumber = sourceEntity.OldCaseNumber;
			Comment = sourceEntity.Comment;
			LineNumber2 = sourceEntity.LineNumber2;
			LogDate = sourceEntity.LogDate;
			LogTime = sourceEntity.LogTime;
			LogUserId = sourceEntity.LogUserId;
			LogExe_Dll = sourceEntity.LogExe_Dll;
			LogForm_Pgm = sourceEntity.LogForm_Pgm;
		}
	}
}
