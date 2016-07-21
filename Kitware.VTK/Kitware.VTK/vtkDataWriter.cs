using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDataWriter : vtkWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDataWriter";

		public new static readonly string MRClassNameKey;

		static vtkDataWriter()
		{
			vtkDataWriter.MRClassNameKey = "class vtkDataWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataWriter"));
		}

		public vtkDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataWriter New()
		{
			vtkDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataWriter.vtkDataWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDataWriter.vtkDataWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_GetBinaryOutputString_01(HandleRef pThis);

		public IntPtr GetBinaryOutputString()
		{
			return vtkDataWriter.vtkDataWriter_GetBinaryOutputString_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_GetFieldDataName_02(HandleRef pThis);

		public virtual string GetFieldDataName()
		{
			return Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetFieldDataName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_GetFileName_03(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetFileName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataWriter_GetFileType_04(HandleRef pThis);

		public virtual int GetFileType()
		{
			return vtkDataWriter.vtkDataWriter_GetFileType_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataWriter_GetFileTypeMaxValue_05(HandleRef pThis);

		public virtual int GetFileTypeMaxValue()
		{
			return vtkDataWriter.vtkDataWriter_GetFileTypeMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataWriter_GetFileTypeMinValue_06(HandleRef pThis);

		public virtual int GetFileTypeMinValue()
		{
			return vtkDataWriter.vtkDataWriter_GetFileTypeMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_GetGlobalIdsName_07(HandleRef pThis);

		public virtual string GetGlobalIdsName()
		{
			return Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetGlobalIdsName_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_GetHeader_08(HandleRef pThis);

		public virtual string GetHeader()
		{
			return Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetHeader_08(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_GetLookupTableName_09(HandleRef pThis);

		public virtual string GetLookupTableName()
		{
			return Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetLookupTableName_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_GetNormalsName_10(HandleRef pThis);

		public virtual string GetNormalsName()
		{
			return Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetNormalsName_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_GetOutputString_11(HandleRef pThis);

		public virtual string GetOutputString()
		{
			return Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetOutputString_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataWriter_GetOutputStringLength_12(HandleRef pThis);

		public virtual int GetOutputStringLength()
		{
			return vtkDataWriter.vtkDataWriter_GetOutputStringLength_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_GetPedigreeIdsName_13(HandleRef pThis);

		public virtual string GetPedigreeIdsName()
		{
			return Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetPedigreeIdsName_13(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_GetScalarsName_14(HandleRef pThis);

		public virtual string GetScalarsName()
		{
			return Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetScalarsName_14(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_GetTCoordsName_15(HandleRef pThis);

		public virtual string GetTCoordsName()
		{
			return Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetTCoordsName_15(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_GetTensorsName_16(HandleRef pThis);

		public virtual string GetTensorsName()
		{
			return Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetTensorsName_16(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_GetVectorsName_17(HandleRef pThis);

		public virtual string GetVectorsName()
		{
			return Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_GetVectorsName_17(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataWriter_GetWriteToOutputString_18(HandleRef pThis);

		public virtual int GetWriteToOutputString()
		{
			return vtkDataWriter.vtkDataWriter_GetWriteToOutputString_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataWriter_IsA_19(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDataWriter.vtkDataWriter_IsA_19(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDataWriter_IsTypeOf_20(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDataWriter.vtkDataWriter_IsTypeOf_20(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_NewInstance_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDataWriter NewInstance()
		{
			vtkDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataWriter.vtkDataWriter_NewInstance_22(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_RegisterAndGetOutputString_23(HandleRef pThis);

		public string RegisterAndGetOutputString()
		{
			return Marshal.PtrToStringAnsi(vtkDataWriter.vtkDataWriter_RegisterAndGetOutputString_23(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDataWriter_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkDataWriter vtkDataWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDataWriter.vtkDataWriter_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataWriter = (vtkDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataWriter.Register(null);
				}
			}
			return vtkDataWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_SetFieldDataName_25(HandleRef pThis, string _arg);

		public virtual void SetFieldDataName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetFieldDataName_25(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_SetFileName_26(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetFileName_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_SetFileType_27(HandleRef pThis, int _arg);

		public virtual void SetFileType(int _arg)
		{
			vtkDataWriter.vtkDataWriter_SetFileType_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_SetFileTypeToASCII_28(HandleRef pThis);

		public void SetFileTypeToASCII()
		{
			vtkDataWriter.vtkDataWriter_SetFileTypeToASCII_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_SetFileTypeToBinary_29(HandleRef pThis);

		public void SetFileTypeToBinary()
		{
			vtkDataWriter.vtkDataWriter_SetFileTypeToBinary_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_SetGlobalIdsName_30(HandleRef pThis, string _arg);

		public virtual void SetGlobalIdsName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetGlobalIdsName_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_SetHeader_31(HandleRef pThis, string _arg);

		public virtual void SetHeader(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetHeader_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_SetLookupTableName_32(HandleRef pThis, string _arg);

		public virtual void SetLookupTableName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetLookupTableName_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_SetNormalsName_33(HandleRef pThis, string _arg);

		public virtual void SetNormalsName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetNormalsName_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_SetPedigreeIdsName_34(HandleRef pThis, string _arg);

		public virtual void SetPedigreeIdsName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetPedigreeIdsName_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_SetScalarsName_35(HandleRef pThis, string _arg);

		public virtual void SetScalarsName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetScalarsName_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_SetTCoordsName_36(HandleRef pThis, string _arg);

		public virtual void SetTCoordsName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetTCoordsName_36(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_SetTensorsName_37(HandleRef pThis, string _arg);

		public virtual void SetTensorsName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetTensorsName_37(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_SetVectorsName_38(HandleRef pThis, string _arg);

		public virtual void SetVectorsName(string _arg)
		{
			vtkDataWriter.vtkDataWriter_SetVectorsName_38(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_SetWriteToOutputString_39(HandleRef pThis, int _arg);

		public virtual void SetWriteToOutputString(int _arg)
		{
			vtkDataWriter.vtkDataWriter_SetWriteToOutputString_39(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_WriteToOutputStringOff_40(HandleRef pThis);

		public virtual void WriteToOutputStringOff()
		{
			vtkDataWriter.vtkDataWriter_WriteToOutputStringOff_40(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDataWriter_WriteToOutputStringOn_41(HandleRef pThis);

		public virtual void WriteToOutputStringOn()
		{
			vtkDataWriter.vtkDataWriter_WriteToOutputStringOn_41(base.GetCppThis());
		}
	}
}
