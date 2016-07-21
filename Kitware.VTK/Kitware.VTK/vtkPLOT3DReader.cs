using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPLOT3DReader : vtkStructuredGridSource
	{
		public enum FILE_BIG_ENDIAN_WrapperEnum
		{
			FILE_BIG_ENDIAN,
			FILE_LITTLE_ENDIAN
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkPLOT3DReader";

		public new static readonly string MRClassNameKey;

		static vtkPLOT3DReader()
		{
			vtkPLOT3DReader.MRClassNameKey = "class vtkPLOT3DReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPLOT3DReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPLOT3DReader"));
		}

		public vtkPLOT3DReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLOT3DReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPLOT3DReader New()
		{
			vtkPLOT3DReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPLOT3DReader.vtkPLOT3DReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPLOT3DReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPLOT3DReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPLOT3DReader.vtkPLOT3DReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_AddFunction_01(HandleRef pThis, int functionNumber);

		public void AddFunction(int functionNumber)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_AddFunction_01(base.GetCppThis(), functionNumber);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_BinaryFileOff_02(HandleRef pThis);

		public virtual void BinaryFileOff()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_BinaryFileOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_BinaryFileOn_03(HandleRef pThis);

		public virtual void BinaryFileOn()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_BinaryFileOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLOT3DReader_CanReadBinaryFile_04(HandleRef pThis, string fname);

		public virtual int CanReadBinaryFile(string fname)
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_CanReadBinaryFile_04(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_DoNotReduceNumberOfOutputsOff_05(HandleRef pThis);

		public virtual void DoNotReduceNumberOfOutputsOff()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_DoNotReduceNumberOfOutputsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_DoNotReduceNumberOfOutputsOn_06(HandleRef pThis);

		public virtual void DoNotReduceNumberOfOutputsOn()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_DoNotReduceNumberOfOutputsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_ForceReadOff_07(HandleRef pThis);

		public virtual void ForceReadOff()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_ForceReadOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_ForceReadOn_08(HandleRef pThis);

		public virtual void ForceReadOn()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_ForceReadOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLOT3DReader_GetBinaryFile_09(HandleRef pThis);

		public virtual int GetBinaryFile()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetBinaryFile_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLOT3DReader_GetByteOrder_10(HandleRef pThis);

		public virtual int GetByteOrder()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetByteOrder_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLOT3DReader_GetByteOrderAsString_11(HandleRef pThis);

		public string GetByteOrderAsString()
		{
			return Marshal.PtrToStringAnsi(vtkPLOT3DReader.vtkPLOT3DReader_GetByteOrderAsString_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLOT3DReader_GetDoNotReduceNumberOfOutputs_12(HandleRef pThis);

		public virtual int GetDoNotReduceNumberOfOutputs()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetDoNotReduceNumberOfOutputs_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLOT3DReader_GetFileName_13(HandleRef pThis);

		public string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkPLOT3DReader.vtkPLOT3DReader_GetFileName_13(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLOT3DReader_GetForceRead_14(HandleRef pThis);

		public virtual int GetForceRead()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetForceRead_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLOT3DReader_GetFunctionFileName_15(HandleRef pThis);

		public virtual string GetFunctionFileName()
		{
			return Marshal.PtrToStringAnsi(vtkPLOT3DReader.vtkPLOT3DReader_GetFunctionFileName_15(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkPLOT3DReader_GetGamma_16(HandleRef pThis);

		public virtual double GetGamma()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetGamma_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLOT3DReader_GetHasByteCount_17(HandleRef pThis);

		public virtual int GetHasByteCount()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetHasByteCount_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLOT3DReader_GetIBlanking_18(HandleRef pThis);

		public virtual int GetIBlanking()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetIBlanking_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLOT3DReader_GetMultiGrid_19(HandleRef pThis);

		public virtual int GetMultiGrid()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetMultiGrid_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLOT3DReader_GetNumberOfGrids_20(HandleRef pThis);

		public int GetNumberOfGrids()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetNumberOfGrids_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLOT3DReader_GetNumberOfOutputs_21(HandleRef pThis);

		public override int GetNumberOfOutputs()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetNumberOfOutputs_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLOT3DReader_GetQFileName_22(HandleRef pThis);

		public virtual string GetQFileName()
		{
			return Marshal.PtrToStringAnsi(vtkPLOT3DReader.vtkPLOT3DReader_GetQFileName_22(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkPLOT3DReader_GetR_23(HandleRef pThis);

		public virtual double GetR()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetR_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLOT3DReader_GetScalarFunctionNumber_24(HandleRef pThis);

		public virtual int GetScalarFunctionNumber()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetScalarFunctionNumber_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLOT3DReader_GetTwoDimensionalGeometry_25(HandleRef pThis);

		public virtual int GetTwoDimensionalGeometry()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetTwoDimensionalGeometry_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkPLOT3DReader_GetUvinf_26(HandleRef pThis);

		public virtual double GetUvinf()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetUvinf_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLOT3DReader_GetVectorFunctionNumber_27(HandleRef pThis);

		public virtual int GetVectorFunctionNumber()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetVectorFunctionNumber_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkPLOT3DReader_GetVvinf_28(HandleRef pThis);

		public virtual double GetVvinf()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetVvinf_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkPLOT3DReader_GetWvinf_29(HandleRef pThis);

		public virtual double GetWvinf()
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_GetWvinf_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLOT3DReader_GetXYZFileName_30(HandleRef pThis);

		public virtual string GetXYZFileName()
		{
			return Marshal.PtrToStringAnsi(vtkPLOT3DReader.vtkPLOT3DReader_GetXYZFileName_30(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_HasByteCountOff_31(HandleRef pThis);

		public virtual void HasByteCountOff()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_HasByteCountOff_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_HasByteCountOn_32(HandleRef pThis);

		public virtual void HasByteCountOn()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_HasByteCountOn_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_IBlankingOff_33(HandleRef pThis);

		public virtual void IBlankingOff()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_IBlankingOff_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_IBlankingOn_34(HandleRef pThis);

		public virtual void IBlankingOn()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_IBlankingOn_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLOT3DReader_IsA_35(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_IsA_35(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkPLOT3DReader_IsTypeOf_36(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPLOT3DReader.vtkPLOT3DReader_IsTypeOf_36(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_MultiGridOff_37(HandleRef pThis);

		public virtual void MultiGridOff()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_MultiGridOff_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_MultiGridOn_38(HandleRef pThis);

		public virtual void MultiGridOn()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_MultiGridOn_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLOT3DReader_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPLOT3DReader NewInstance()
		{
			vtkPLOT3DReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPLOT3DReader.vtkPLOT3DReader_NewInstance_40(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPLOT3DReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_RemoveAllFunctions_41(HandleRef pThis);

		public void RemoveAllFunctions()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_RemoveAllFunctions_41(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_RemoveFunction_42(HandleRef pThis, int arg0);

		public void RemoveFunction(int arg0)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_RemoveFunction_42(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkPLOT3DReader_SafeDownCast_43(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPLOT3DReader SafeDownCast(vtkObjectBase o)
		{
			vtkPLOT3DReader vtkPLOT3DReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPLOT3DReader.vtkPLOT3DReader_SafeDownCast_43((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPLOT3DReader = (vtkPLOT3DReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPLOT3DReader.Register(null);
				}
			}
			return vtkPLOT3DReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetBinaryFile_44(HandleRef pThis, int _arg);

		public virtual void SetBinaryFile(int _arg)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetBinaryFile_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetByteOrder_45(HandleRef pThis, int _arg);

		public virtual void SetByteOrder(int _arg)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetByteOrder_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetByteOrderToBigEndian_46(HandleRef pThis);

		public void SetByteOrderToBigEndian()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetByteOrderToBigEndian_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetByteOrderToLittleEndian_47(HandleRef pThis);

		public void SetByteOrderToLittleEndian()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetByteOrderToLittleEndian_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetDoNotReduceNumberOfOutputs_48(HandleRef pThis, int _arg);

		public virtual void SetDoNotReduceNumberOfOutputs(int _arg)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetDoNotReduceNumberOfOutputs_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetFileName_49(HandleRef pThis, string name);

		public void SetFileName(string name)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetFileName_49(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetForceRead_50(HandleRef pThis, int _arg);

		public virtual void SetForceRead(int _arg)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetForceRead_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetFunctionFileName_51(HandleRef pThis, string _arg);

		public virtual void SetFunctionFileName(string _arg)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetFunctionFileName_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetGamma_52(HandleRef pThis, double _arg);

		public virtual void SetGamma(double _arg)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetGamma_52(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetHasByteCount_53(HandleRef pThis, int _arg);

		public virtual void SetHasByteCount(int _arg)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetHasByteCount_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetIBlanking_54(HandleRef pThis, int _arg);

		public virtual void SetIBlanking(int _arg)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetIBlanking_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetMultiGrid_55(HandleRef pThis, int _arg);

		public virtual void SetMultiGrid(int _arg)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetMultiGrid_55(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetOutput_56(HandleRef pThis, int idx, HandleRef output);

		public void SetOutput(int idx, vtkStructuredGrid output)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetOutput_56(base.GetCppThis(), idx, (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetQFileName_57(HandleRef pThis, string _arg);

		public virtual void SetQFileName(string _arg)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetQFileName_57(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetR_58(HandleRef pThis, double _arg);

		public virtual void SetR(double _arg)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetR_58(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetScalarFunctionNumber_59(HandleRef pThis, int num);

		public void SetScalarFunctionNumber(int num)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetScalarFunctionNumber_59(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetTwoDimensionalGeometry_60(HandleRef pThis, int _arg);

		public virtual void SetTwoDimensionalGeometry(int _arg)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetTwoDimensionalGeometry_60(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetUvinf_61(HandleRef pThis, double _arg);

		public virtual void SetUvinf(double _arg)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetUvinf_61(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetVectorFunctionNumber_62(HandleRef pThis, int num);

		public void SetVectorFunctionNumber(int num)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetVectorFunctionNumber_62(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetVvinf_63(HandleRef pThis, double _arg);

		public virtual void SetVvinf(double _arg)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetVvinf_63(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetWvinf_64(HandleRef pThis, double _arg);

		public virtual void SetWvinf(double _arg)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetWvinf_64(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_SetXYZFileName_65(HandleRef pThis, string arg0);

		public virtual void SetXYZFileName(string arg0)
		{
			vtkPLOT3DReader.vtkPLOT3DReader_SetXYZFileName_65(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_TwoDimensionalGeometryOff_66(HandleRef pThis);

		public virtual void TwoDimensionalGeometryOff()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_TwoDimensionalGeometryOff_66(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkPLOT3DReader_TwoDimensionalGeometryOn_67(HandleRef pThis);

		public virtual void TwoDimensionalGeometryOn()
		{
			vtkPLOT3DReader.vtkPLOT3DReader_TwoDimensionalGeometryOn_67(base.GetCppThis());
		}
	}
}
