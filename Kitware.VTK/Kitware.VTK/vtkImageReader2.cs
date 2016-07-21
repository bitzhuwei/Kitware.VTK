using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageReader2 : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageReader2";

		public new static readonly string MRClassNameKey;

		static vtkImageReader2()
		{
			vtkImageReader2.MRClassNameKey = "class vtkImageReader2";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageReader2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageReader2"));
		}

		public vtkImageReader2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageReader2 New()
		{
			vtkImageReader2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageReader2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageReader2.vtkImageReader2_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader2_CanReadFile_01(HandleRef pThis, string arg0);

		public virtual int CanReadFile(string arg0)
		{
			return vtkImageReader2.vtkImageReader2_CanReadFile_01(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_ComputeInternalFileName_02(HandleRef pThis, int slice);

		public virtual void ComputeInternalFileName(int slice)
		{
			vtkImageReader2.vtkImageReader2_ComputeInternalFileName_02(base.GetCppThis(), slice);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_FileLowerLeftOff_03(HandleRef pThis);

		public virtual void FileLowerLeftOff()
		{
			vtkImageReader2.vtkImageReader2_FileLowerLeftOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_FileLowerLeftOn_04(HandleRef pThis);

		public virtual void FileLowerLeftOn()
		{
			vtkImageReader2.vtkImageReader2_FileLowerLeftOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader2_GetDataByteOrder_05(HandleRef pThis);

		public virtual int GetDataByteOrder()
		{
			return vtkImageReader2.vtkImageReader2_GetDataByteOrder_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2_GetDataByteOrderAsString_06(HandleRef pThis);

		public virtual string GetDataByteOrderAsString()
		{
			return Marshal.PtrToStringAnsi(vtkImageReader2.vtkImageReader2_GetDataByteOrderAsString_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2_GetDataExtent_07(HandleRef pThis);

		public virtual int[] GetDataExtent()
		{
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_GetDataExtent_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_GetDataExtent_08(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetDataExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageReader2.vtkImageReader2_GetDataExtent_08(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_GetDataExtent_09(HandleRef pThis, IntPtr _arg);

		public virtual void GetDataExtent(IntPtr _arg)
		{
			vtkImageReader2.vtkImageReader2_GetDataExtent_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2_GetDataIncrements_10(HandleRef pThis);

		public virtual uint[] GetDataIncrements()
		{
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_GetDataIncrements_10(base.GetCppThis());
			uint[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new uint[4];
				int[] array2 = new int[4];
				Marshal.Copy(intPtr, array2, 0, array.Length);
				for (int i = 0; i < 4; i++)
				{
					array[i] = (uint)array2[i];
				}
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_GetDataIncrements_11(HandleRef pThis, IntPtr data);

		public virtual void GetDataIncrements(IntPtr data)
		{
			vtkImageReader2.vtkImageReader2_GetDataIncrements_11(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2_GetDataOrigin_12(HandleRef pThis);

		public virtual double[] GetDataOrigin()
		{
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_GetDataOrigin_12(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_GetDataOrigin_13(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetDataOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageReader2.vtkImageReader2_GetDataOrigin_13(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_GetDataOrigin_14(HandleRef pThis, IntPtr _arg);

		public virtual void GetDataOrigin(IntPtr _arg)
		{
			vtkImageReader2.vtkImageReader2_GetDataOrigin_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader2_GetDataScalarType_15(HandleRef pThis);

		public virtual int GetDataScalarType()
		{
			return vtkImageReader2.vtkImageReader2_GetDataScalarType_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2_GetDataSpacing_16(HandleRef pThis);

		public virtual double[] GetDataSpacing()
		{
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_GetDataSpacing_16(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_GetDataSpacing_17(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetDataSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageReader2.vtkImageReader2_GetDataSpacing_17(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_GetDataSpacing_18(HandleRef pThis, IntPtr _arg);

		public virtual void GetDataSpacing(IntPtr _arg)
		{
			vtkImageReader2.vtkImageReader2_GetDataSpacing_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2_GetDescriptiveName_19(HandleRef pThis);

		public virtual string GetDescriptiveName()
		{
			return Marshal.PtrToStringAnsi(vtkImageReader2.vtkImageReader2_GetDescriptiveName_19(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader2_GetFileDimensionality_20(HandleRef pThis);

		public int GetFileDimensionality()
		{
			return vtkImageReader2.vtkImageReader2_GetFileDimensionality_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2_GetFileExtensions_21(HandleRef pThis);

		public virtual string GetFileExtensions()
		{
			return Marshal.PtrToStringAnsi(vtkImageReader2.vtkImageReader2_GetFileExtensions_21(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader2_GetFileLowerLeft_22(HandleRef pThis);

		public virtual int GetFileLowerLeft()
		{
			return vtkImageReader2.vtkImageReader2_GetFileLowerLeft_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2_GetFileName_23(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkImageReader2.vtkImageReader2_GetFileName_23(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader2_GetFileNameSliceOffset_24(HandleRef pThis);

		public virtual int GetFileNameSliceOffset()
		{
			return vtkImageReader2.vtkImageReader2_GetFileNameSliceOffset_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader2_GetFileNameSliceSpacing_25(HandleRef pThis);

		public virtual int GetFileNameSliceSpacing()
		{
			return vtkImageReader2.vtkImageReader2_GetFileNameSliceSpacing_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2_GetFileNames_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkStringArray GetFileNames()
		{
			vtkStringArray vtkStringArray = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_GetFileNames_26(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringArray = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringArray.Register(null);
				}
			}
			return vtkStringArray;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2_GetFilePattern_27(HandleRef pThis);

		public virtual string GetFilePattern()
		{
			return Marshal.PtrToStringAnsi(vtkImageReader2.vtkImageReader2_GetFilePattern_27(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2_GetFilePrefix_28(HandleRef pThis);

		public virtual string GetFilePrefix()
		{
			return Marshal.PtrToStringAnsi(vtkImageReader2.vtkImageReader2_GetFilePrefix_28(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkImageReader2_GetHeaderSize_29(HandleRef pThis);

		public uint GetHeaderSize()
		{
			return vtkImageReader2.vtkImageReader2_GetHeaderSize_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkImageReader2_GetHeaderSize_30(HandleRef pThis, uint slice);

		public uint GetHeaderSize(uint slice)
		{
			return vtkImageReader2.vtkImageReader2_GetHeaderSize_30(base.GetCppThis(), slice);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2_GetInternalFileName_31(HandleRef pThis);

		public virtual string GetInternalFileName()
		{
			return Marshal.PtrToStringAnsi(vtkImageReader2.vtkImageReader2_GetInternalFileName_31(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader2_GetNumberOfScalarComponents_32(HandleRef pThis);

		public virtual int GetNumberOfScalarComponents()
		{
			return vtkImageReader2.vtkImageReader2_GetNumberOfScalarComponents_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader2_GetSwapBytes_33(HandleRef pThis);

		public virtual int GetSwapBytes()
		{
			return vtkImageReader2.vtkImageReader2_GetSwapBytes_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader2_IsA_34(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageReader2.vtkImageReader2_IsA_34(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader2_IsTypeOf_35(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageReader2.vtkImageReader2_IsTypeOf_35(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2_NewInstance_37(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageReader2 NewInstance()
		{
			vtkImageReader2 result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_NewInstance_37(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkImageReader2_OpenFile_38(HandleRef pThis);

		public virtual int OpenFile()
		{
			return vtkImageReader2.vtkImageReader2_OpenFile_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkImageReader2_SafeDownCast_39(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageReader2 SafeDownCast(vtkObjectBase o)
		{
			vtkImageReader2 vtkImageReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageReader2.vtkImageReader2_SafeDownCast_39((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageReader = (vtkImageReader2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageReader.Register(null);
				}
			}
			return vtkImageReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SeekFile_40(HandleRef pThis, int i, int j, int k);

		public virtual void SeekFile(int i, int j, int k)
		{
			vtkImageReader2.vtkImageReader2_SeekFile_40(base.GetCppThis(), i, j, k);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataByteOrder_41(HandleRef pThis, int arg0);

		public virtual void SetDataByteOrder(int arg0)
		{
			vtkImageReader2.vtkImageReader2_SetDataByteOrder_41(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataByteOrderToBigEndian_42(HandleRef pThis);

		public virtual void SetDataByteOrderToBigEndian()
		{
			vtkImageReader2.vtkImageReader2_SetDataByteOrderToBigEndian_42(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataByteOrderToLittleEndian_43(HandleRef pThis);

		public virtual void SetDataByteOrderToLittleEndian()
		{
			vtkImageReader2.vtkImageReader2_SetDataByteOrderToLittleEndian_43(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataExtent_44(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetDataExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkImageReader2.vtkImageReader2_SetDataExtent_44(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataExtent_45(HandleRef pThis, IntPtr _arg);

		public virtual void SetDataExtent(IntPtr _arg)
		{
			vtkImageReader2.vtkImageReader2_SetDataExtent_45(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataOrigin_46(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDataOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkImageReader2.vtkImageReader2_SetDataOrigin_46(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataOrigin_47(HandleRef pThis, IntPtr _arg);

		public virtual void SetDataOrigin(IntPtr _arg)
		{
			vtkImageReader2.vtkImageReader2_SetDataOrigin_47(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataScalarType_48(HandleRef pThis, int type);

		public virtual void SetDataScalarType(int type)
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarType_48(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataScalarTypeToChar_49(HandleRef pThis);

		public virtual void SetDataScalarTypeToChar()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToChar_49(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataScalarTypeToDouble_50(HandleRef pThis);

		public virtual void SetDataScalarTypeToDouble()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToDouble_50(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataScalarTypeToFloat_51(HandleRef pThis);

		public virtual void SetDataScalarTypeToFloat()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToFloat_51(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataScalarTypeToInt_52(HandleRef pThis);

		public virtual void SetDataScalarTypeToInt()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToInt_52(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataScalarTypeToShort_53(HandleRef pThis);

		public virtual void SetDataScalarTypeToShort()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToShort_53(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataScalarTypeToSignedChar_54(HandleRef pThis);

		public virtual void SetDataScalarTypeToSignedChar()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToSignedChar_54(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataScalarTypeToUnsignedChar_55(HandleRef pThis);

		public virtual void SetDataScalarTypeToUnsignedChar()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToUnsignedChar_55(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataScalarTypeToUnsignedInt_56(HandleRef pThis);

		public virtual void SetDataScalarTypeToUnsignedInt()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToUnsignedInt_56(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataScalarTypeToUnsignedShort_57(HandleRef pThis);

		public virtual void SetDataScalarTypeToUnsignedShort()
		{
			vtkImageReader2.vtkImageReader2_SetDataScalarTypeToUnsignedShort_57(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataSpacing_58(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDataSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkImageReader2.vtkImageReader2_SetDataSpacing_58(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetDataSpacing_59(HandleRef pThis, IntPtr _arg);

		public virtual void SetDataSpacing(IntPtr _arg)
		{
			vtkImageReader2.vtkImageReader2_SetDataSpacing_59(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetFileDimensionality_60(HandleRef pThis, int _arg);

		public virtual void SetFileDimensionality(int _arg)
		{
			vtkImageReader2.vtkImageReader2_SetFileDimensionality_60(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetFileLowerLeft_61(HandleRef pThis, int _arg);

		public virtual void SetFileLowerLeft(int _arg)
		{
			vtkImageReader2.vtkImageReader2_SetFileLowerLeft_61(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetFileName_62(HandleRef pThis, string arg0);

		public virtual void SetFileName(string arg0)
		{
			vtkImageReader2.vtkImageReader2_SetFileName_62(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetFileNameSliceOffset_63(HandleRef pThis, int _arg);

		public virtual void SetFileNameSliceOffset(int _arg)
		{
			vtkImageReader2.vtkImageReader2_SetFileNameSliceOffset_63(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetFileNameSliceSpacing_64(HandleRef pThis, int _arg);

		public virtual void SetFileNameSliceSpacing(int _arg)
		{
			vtkImageReader2.vtkImageReader2_SetFileNameSliceSpacing_64(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetFileNames_65(HandleRef pThis, HandleRef arg0);

		public virtual void SetFileNames(vtkStringArray arg0)
		{
			vtkImageReader2.vtkImageReader2_SetFileNames_65(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetFilePattern_66(HandleRef pThis, string arg0);

		public virtual void SetFilePattern(string arg0)
		{
			vtkImageReader2.vtkImageReader2_SetFilePattern_66(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetFilePrefix_67(HandleRef pThis, string arg0);

		public virtual void SetFilePrefix(string arg0)
		{
			vtkImageReader2.vtkImageReader2_SetFilePrefix_67(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetHeaderSize_68(HandleRef pThis, uint size);

		public virtual void SetHeaderSize(uint size)
		{
			vtkImageReader2.vtkImageReader2_SetHeaderSize_68(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetNumberOfScalarComponents_69(HandleRef pThis, int _arg);

		public virtual void SetNumberOfScalarComponents(int _arg)
		{
			vtkImageReader2.vtkImageReader2_SetNumberOfScalarComponents_69(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SetSwapBytes_70(HandleRef pThis, int _arg);

		public virtual void SetSwapBytes(int _arg)
		{
			vtkImageReader2.vtkImageReader2_SetSwapBytes_70(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SwapBytesOff_71(HandleRef pThis);

		public virtual void SwapBytesOff()
		{
			vtkImageReader2.vtkImageReader2_SwapBytesOff_71(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkImageReader2_SwapBytesOn_72(HandleRef pThis);

		public virtual void SwapBytesOn()
		{
			vtkImageReader2.vtkImageReader2_SwapBytesOn_72(base.GetCppThis());
		}
	}
}
