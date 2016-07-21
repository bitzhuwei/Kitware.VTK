using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDelimitedTextReader : vtkTableAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDelimitedTextReader";

		public new static readonly string MRClassNameKey;

		static vtkDelimitedTextReader()
		{
			vtkDelimitedTextReader.MRClassNameKey = "class vtkDelimitedTextReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDelimitedTextReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDelimitedTextReader"));
		}

		public vtkDelimitedTextReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDelimitedTextReader New()
		{
			vtkDelimitedTextReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDelimitedTextReader.vtkDelimitedTextReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDelimitedTextReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDelimitedTextReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDelimitedTextReader.vtkDelimitedTextReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_DetectNumericColumnsOff_01(HandleRef pThis);

		public virtual void DetectNumericColumnsOff()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_DetectNumericColumnsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_DetectNumericColumnsOn_02(HandleRef pThis);

		public virtual void DetectNumericColumnsOn()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_DetectNumericColumnsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_GeneratePedigreeIdsOff_03(HandleRef pThis);

		public virtual void GeneratePedigreeIdsOff()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_GeneratePedigreeIdsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_GeneratePedigreeIdsOn_04(HandleRef pThis);

		public virtual void GeneratePedigreeIdsOn()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_GeneratePedigreeIdsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkDelimitedTextReader_GetDetectNumericColumns_05(HandleRef pThis);

		public virtual bool GetDetectNumericColumns()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetDetectNumericColumns_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextReader_GetFieldDelimiterCharacters_06(HandleRef pThis);

		public virtual string GetFieldDelimiterCharacters()
		{
			return Marshal.PtrToStringAnsi(vtkDelimitedTextReader.vtkDelimitedTextReader_GetFieldDelimiterCharacters_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextReader_GetFileName_07(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkDelimitedTextReader.vtkDelimitedTextReader_GetFileName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkDelimitedTextReader_GetGeneratePedigreeIds_08(HandleRef pThis);

		public virtual bool GetGeneratePedigreeIds()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetGeneratePedigreeIds_08(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkDelimitedTextReader_GetHaveHeaders_09(HandleRef pThis);

		public virtual bool GetHaveHeaders()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetHaveHeaders_09(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkDelimitedTextReader_GetMaxRecords_10(HandleRef pThis);

		public virtual long GetMaxRecords()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetMaxRecords_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkDelimitedTextReader_GetMergeConsecutiveDelimiters_11(HandleRef pThis);

		public virtual bool GetMergeConsecutiveDelimiters()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetMergeConsecutiveDelimiters_11(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkDelimitedTextReader_GetOutputPedigreeIds_12(HandleRef pThis);

		public virtual bool GetOutputPedigreeIds()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetOutputPedigreeIds_12(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextReader_GetPedigreeIdArrayName_13(HandleRef pThis);

		public virtual string GetPedigreeIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkDelimitedTextReader.vtkDelimitedTextReader_GetPedigreeIdArrayName_13(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern uint vtkDelimitedTextReader_GetReplacementCharacter_14(HandleRef pThis);

		public virtual uint GetReplacementCharacter()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetReplacementCharacter_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern sbyte vtkDelimitedTextReader_GetStringDelimiter_15(HandleRef pThis);

		public virtual sbyte GetStringDelimiter()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetStringDelimiter_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextReader_GetUTF8FieldDelimiters_16(HandleRef pThis);

		public string GetUTF8FieldDelimiters()
		{
			return Marshal.PtrToStringAnsi(vtkDelimitedTextReader.vtkDelimitedTextReader_GetUTF8FieldDelimiters_16(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextReader_GetUTF8RecordDelimiters_17(HandleRef pThis);

		public string GetUTF8RecordDelimiters()
		{
			return Marshal.PtrToStringAnsi(vtkDelimitedTextReader.vtkDelimitedTextReader_GetUTF8RecordDelimiters_17(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextReader_GetUTF8StringDelimiters_18(HandleRef pThis);

		public string GetUTF8StringDelimiters()
		{
			return Marshal.PtrToStringAnsi(vtkDelimitedTextReader.vtkDelimitedTextReader_GetUTF8StringDelimiters_18(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextReader_GetUnicodeCharacterSet_19(HandleRef pThis);

		public virtual string GetUnicodeCharacterSet()
		{
			return Marshal.PtrToStringAnsi(vtkDelimitedTextReader.vtkDelimitedTextReader_GetUnicodeCharacterSet_19(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkDelimitedTextReader_GetUseStringDelimiter_20(HandleRef pThis);

		public virtual bool GetUseStringDelimiter()
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_GetUseStringDelimiter_20(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDelimitedTextReader_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkDelimitedTextReader_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDelimitedTextReader.vtkDelimitedTextReader_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_MergeConsecutiveDelimitersOff_23(HandleRef pThis);

		public virtual void MergeConsecutiveDelimitersOff()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_MergeConsecutiveDelimitersOff_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_MergeConsecutiveDelimitersOn_24(HandleRef pThis);

		public virtual void MergeConsecutiveDelimitersOn()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_MergeConsecutiveDelimitersOn_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextReader_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDelimitedTextReader NewInstance()
		{
			vtkDelimitedTextReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDelimitedTextReader.vtkDelimitedTextReader_NewInstance_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDelimitedTextReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_OutputPedigreeIdsOff_27(HandleRef pThis);

		public virtual void OutputPedigreeIdsOff()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_OutputPedigreeIdsOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_OutputPedigreeIdsOn_28(HandleRef pThis);

		public virtual void OutputPedigreeIdsOn()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_OutputPedigreeIdsOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextReader_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDelimitedTextReader SafeDownCast(vtkObjectBase o)
		{
			vtkDelimitedTextReader vtkDelimitedTextReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDelimitedTextReader.vtkDelimitedTextReader_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDelimitedTextReader = (vtkDelimitedTextReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDelimitedTextReader.Register(null);
				}
			}
			return vtkDelimitedTextReader;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_SetDetectNumericColumns_30(HandleRef pThis, byte _arg);

		public virtual void SetDetectNumericColumns(bool _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetDetectNumericColumns_30(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_SetFieldDelimiterCharacters_31(HandleRef pThis, string _arg);

		public virtual void SetFieldDelimiterCharacters(string _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetFieldDelimiterCharacters_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_SetFileName_32(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetFileName_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_SetGeneratePedigreeIds_33(HandleRef pThis, byte _arg);

		public virtual void SetGeneratePedigreeIds(bool _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetGeneratePedigreeIds_33(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_SetHaveHeaders_34(HandleRef pThis, byte _arg);

		public virtual void SetHaveHeaders(bool _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetHaveHeaders_34(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_SetMaxRecords_35(HandleRef pThis, long _arg);

		public virtual void SetMaxRecords(long _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetMaxRecords_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_SetMergeConsecutiveDelimiters_36(HandleRef pThis, byte _arg);

		public virtual void SetMergeConsecutiveDelimiters(bool _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetMergeConsecutiveDelimiters_36(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_SetOutputPedigreeIds_37(HandleRef pThis, byte _arg);

		public virtual void SetOutputPedigreeIds(bool _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetOutputPedigreeIds_37(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_SetPedigreeIdArrayName_38(HandleRef pThis, string _arg);

		public virtual void SetPedigreeIdArrayName(string _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetPedigreeIdArrayName_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_SetReplacementCharacter_39(HandleRef pThis, uint _arg);

		public virtual void SetReplacementCharacter(uint _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetReplacementCharacter_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_SetStringDelimiter_40(HandleRef pThis, sbyte _arg);

		public virtual void SetStringDelimiter(sbyte _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetStringDelimiter_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_SetUTF8FieldDelimiters_41(HandleRef pThis, string delimiters);

		public void SetUTF8FieldDelimiters(string delimiters)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetUTF8FieldDelimiters_41(base.GetCppThis(), delimiters);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_SetUTF8RecordDelimiters_42(HandleRef pThis, string delimiters);

		public void SetUTF8RecordDelimiters(string delimiters)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetUTF8RecordDelimiters_42(base.GetCppThis(), delimiters);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_SetUTF8StringDelimiters_43(HandleRef pThis, string delimiters);

		public void SetUTF8StringDelimiters(string delimiters)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetUTF8StringDelimiters_43(base.GetCppThis(), delimiters);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_SetUnicodeCharacterSet_44(HandleRef pThis, string _arg);

		public virtual void SetUnicodeCharacterSet(string _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetUnicodeCharacterSet_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_SetUseStringDelimiter_45(HandleRef pThis, byte _arg);

		public virtual void SetUseStringDelimiter(bool _arg)
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_SetUseStringDelimiter_45(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_UseStringDelimiterOff_46(HandleRef pThis);

		public virtual void UseStringDelimiterOff()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_UseStringDelimiterOff_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextReader_UseStringDelimiterOn_47(HandleRef pThis);

		public virtual void UseStringDelimiterOn()
		{
			vtkDelimitedTextReader.vtkDelimitedTextReader_UseStringDelimiterOn_47(base.GetCppThis());
		}
	}
}
