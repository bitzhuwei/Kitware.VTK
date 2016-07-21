using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMultiBlockPLOT3DReader : vtkMultiBlockDataSetAlgorithm
	{
		public enum FILE_BIG_ENDIAN_WrapperEnum
		{
			FILE_BIG_ENDIAN,
			FILE_LITTLE_ENDIAN
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkMultiBlockPLOT3DReader";

		public new static readonly string MRClassNameKey;

		static vtkMultiBlockPLOT3DReader()
		{
			vtkMultiBlockPLOT3DReader.MRClassNameKey = "class vtkMultiBlockPLOT3DReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMultiBlockPLOT3DReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMultiBlockPLOT3DReader"));
		}

		public vtkMultiBlockPLOT3DReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiBlockPLOT3DReader New()
		{
			vtkMultiBlockPLOT3DReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockPLOT3DReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMultiBlockPLOT3DReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_AddFunction_01(HandleRef pThis, int functionNumber);

		public void AddFunction(int functionNumber)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_AddFunction_01(base.GetCppThis(), functionNumber);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_BinaryFileOff_02(HandleRef pThis);

		public virtual void BinaryFileOff()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_BinaryFileOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_BinaryFileOn_03(HandleRef pThis);

		public virtual void BinaryFileOn()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_BinaryFileOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMultiBlockPLOT3DReader_CanReadBinaryFile_04(HandleRef pThis, string fname);

		public virtual int CanReadBinaryFile(string fname)
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_CanReadBinaryFile_04(base.GetCppThis(), fname);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_ForceReadOff_05(HandleRef pThis);

		public virtual void ForceReadOff()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_ForceReadOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_ForceReadOn_06(HandleRef pThis);

		public virtual void ForceReadOn()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_ForceReadOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMultiBlockPLOT3DReader_GetBinaryFile_07(HandleRef pThis);

		public virtual int GetBinaryFile()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetBinaryFile_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMultiBlockPLOT3DReader_GetByteOrder_08(HandleRef pThis);

		public virtual int GetByteOrder()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetByteOrder_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetByteOrderAsString_09(HandleRef pThis);

		public string GetByteOrderAsString()
		{
			return Marshal.PtrToStringAnsi(vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetByteOrderAsString_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetFileName_10(HandleRef pThis);

		public string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetFileName_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMultiBlockPLOT3DReader_GetForceRead_11(HandleRef pThis);

		public virtual int GetForceRead()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetForceRead_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMultiBlockPLOT3DReader_GetGamma_12(HandleRef pThis);

		public virtual double GetGamma()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetGamma_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMultiBlockPLOT3DReader_GetHasByteCount_13(HandleRef pThis);

		public virtual int GetHasByteCount()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetHasByteCount_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMultiBlockPLOT3DReader_GetIBlanking_14(HandleRef pThis);

		public virtual int GetIBlanking()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetIBlanking_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMultiBlockPLOT3DReader_GetMultiGrid_15(HandleRef pThis);

		public virtual int GetMultiGrid()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetMultiGrid_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMultiBlockPLOT3DReader_GetNumberOfBlocks_16(HandleRef pThis);

		public int GetNumberOfBlocks()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetNumberOfBlocks_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMultiBlockPLOT3DReader_GetNumberOfGrids_17(HandleRef pThis);

		public int GetNumberOfGrids()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetNumberOfGrids_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetQFileName_18(HandleRef pThis);

		public virtual string GetQFileName()
		{
			return Marshal.PtrToStringAnsi(vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetQFileName_18(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMultiBlockPLOT3DReader_GetR_19(HandleRef pThis);

		public virtual double GetR()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetR_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMultiBlockPLOT3DReader_GetScalarFunctionNumber_20(HandleRef pThis);

		public virtual int GetScalarFunctionNumber()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetScalarFunctionNumber_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMultiBlockPLOT3DReader_GetTwoDimensionalGeometry_21(HandleRef pThis);

		public virtual int GetTwoDimensionalGeometry()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetTwoDimensionalGeometry_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMultiBlockPLOT3DReader_GetUvinf_22(HandleRef pThis);

		public virtual double GetUvinf()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetUvinf_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMultiBlockPLOT3DReader_GetVectorFunctionNumber_23(HandleRef pThis);

		public virtual int GetVectorFunctionNumber()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetVectorFunctionNumber_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMultiBlockPLOT3DReader_GetVvinf_24(HandleRef pThis);

		public virtual double GetVvinf()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetVvinf_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern double vtkMultiBlockPLOT3DReader_GetWvinf_25(HandleRef pThis);

		public virtual double GetWvinf()
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetWvinf_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_GetXYZFileName_26(HandleRef pThis);

		public virtual string GetXYZFileName()
		{
			return Marshal.PtrToStringAnsi(vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_GetXYZFileName_26(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_HasByteCountOff_27(HandleRef pThis);

		public virtual void HasByteCountOff()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_HasByteCountOff_27(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_HasByteCountOn_28(HandleRef pThis);

		public virtual void HasByteCountOn()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_HasByteCountOn_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_IBlankingOff_29(HandleRef pThis);

		public virtual void IBlankingOff()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_IBlankingOff_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_IBlankingOn_30(HandleRef pThis);

		public virtual void IBlankingOn()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_IBlankingOn_30(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMultiBlockPLOT3DReader_IsA_31(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_IsA_31(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMultiBlockPLOT3DReader_IsTypeOf_32(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_IsTypeOf_32(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_MultiGridOff_33(HandleRef pThis);

		public virtual void MultiGridOff()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_MultiGridOff_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_MultiGridOn_34(HandleRef pThis);

		public virtual void MultiGridOn()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_MultiGridOn_34(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMultiBlockPLOT3DReader NewInstance()
		{
			vtkMultiBlockPLOT3DReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_NewInstance_36(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMultiBlockPLOT3DReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_RemoveAllFunctions_37(HandleRef pThis);

		public void RemoveAllFunctions()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_RemoveAllFunctions_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_RemoveFunction_38(HandleRef pThis, int arg0);

		public void RemoveFunction(int arg0)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_RemoveFunction_38(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMultiBlockPLOT3DReader_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMultiBlockPLOT3DReader SafeDownCast(vtkObjectBase o)
		{
			vtkMultiBlockPLOT3DReader vtkMultiBlockPLOT3DReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SafeDownCast_39((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiBlockPLOT3DReader = (vtkMultiBlockPLOT3DReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiBlockPLOT3DReader.Register(null);
				}
			}
			return vtkMultiBlockPLOT3DReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetBinaryFile_40(HandleRef pThis, int _arg);

		public virtual void SetBinaryFile(int _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetBinaryFile_40(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetByteOrder_41(HandleRef pThis, int _arg);

		public virtual void SetByteOrder(int _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetByteOrder_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetByteOrderToBigEndian_42(HandleRef pThis);

		public void SetByteOrderToBigEndian()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetByteOrderToBigEndian_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetByteOrderToLittleEndian_43(HandleRef pThis);

		public void SetByteOrderToLittleEndian()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetByteOrderToLittleEndian_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetFileName_44(HandleRef pThis, string name);

		public void SetFileName(string name)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetFileName_44(base.GetCppThis(), name);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetForceRead_45(HandleRef pThis, int _arg);

		public virtual void SetForceRead(int _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetForceRead_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetGamma_46(HandleRef pThis, double _arg);

		public virtual void SetGamma(double _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetGamma_46(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetHasByteCount_47(HandleRef pThis, int _arg);

		public virtual void SetHasByteCount(int _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetHasByteCount_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetIBlanking_48(HandleRef pThis, int _arg);

		public virtual void SetIBlanking(int _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetIBlanking_48(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetMultiGrid_49(HandleRef pThis, int _arg);

		public virtual void SetMultiGrid(int _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetMultiGrid_49(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetQFileName_50(HandleRef pThis, string _arg);

		public virtual void SetQFileName(string _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetQFileName_50(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetR_51(HandleRef pThis, double _arg);

		public virtual void SetR(double _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetR_51(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetScalarFunctionNumber_52(HandleRef pThis, int num);

		public void SetScalarFunctionNumber(int num)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetScalarFunctionNumber_52(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetTwoDimensionalGeometry_53(HandleRef pThis, int _arg);

		public virtual void SetTwoDimensionalGeometry(int _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetTwoDimensionalGeometry_53(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetUvinf_54(HandleRef pThis, double _arg);

		public virtual void SetUvinf(double _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetUvinf_54(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetVectorFunctionNumber_55(HandleRef pThis, int num);

		public void SetVectorFunctionNumber(int num)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetVectorFunctionNumber_55(base.GetCppThis(), num);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetVvinf_56(HandleRef pThis, double _arg);

		public virtual void SetVvinf(double _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetVvinf_56(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetWvinf_57(HandleRef pThis, double _arg);

		public virtual void SetWvinf(double _arg)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetWvinf_57(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_SetXYZFileName_58(HandleRef pThis, string arg0);

		public virtual void SetXYZFileName(string arg0)
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_SetXYZFileName_58(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_TwoDimensionalGeometryOff_59(HandleRef pThis);

		public virtual void TwoDimensionalGeometryOff()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_TwoDimensionalGeometryOff_59(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMultiBlockPLOT3DReader_TwoDimensionalGeometryOn_60(HandleRef pThis);

		public virtual void TwoDimensionalGeometryOn()
		{
			vtkMultiBlockPLOT3DReader.vtkMultiBlockPLOT3DReader_TwoDimensionalGeometryOn_60(base.GetCppThis());
		}
	}
}
