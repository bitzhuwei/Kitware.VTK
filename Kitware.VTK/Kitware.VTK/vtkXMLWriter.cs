using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkXMLWriter : vtkAlgorithm
	{
		public enum BigEndian_WrapperEnum
		{
			BigEndian,
			LittleEndian
		}

		public enum Appended_WrapperEnum
		{
			Appended = 2,
			Ascii = 0,
			Binary
		}

		public enum Int32_WrapperEnum
		{
			Int32 = 32,
			Int64 = 64
		}

		public enum CompressorType
		{
			NONE,
			ZLIB
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLWriter";

		public new static readonly string MRClassNameKey;

		static vtkXMLWriter()
		{
			vtkXMLWriter.MRClassNameKey = "class vtkXMLWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLWriter"));
		}

		public vtkXMLWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_EncodeAppendedDataOff_01(HandleRef pThis);

		public virtual void EncodeAppendedDataOff()
		{
			vtkXMLWriter.vtkXMLWriter_EncodeAppendedDataOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_EncodeAppendedDataOn_02(HandleRef pThis);

		public virtual void EncodeAppendedDataOn()
		{
			vtkXMLWriter.vtkXMLWriter_EncodeAppendedDataOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkXMLWriter_GetBlockSize_03(HandleRef pThis);

		public virtual uint GetBlockSize()
		{
			return vtkXMLWriter.vtkXMLWriter_GetBlockSize_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLWriter_GetByteOrder_04(HandleRef pThis);

		public virtual int GetByteOrder()
		{
			return vtkXMLWriter.vtkXMLWriter_GetByteOrder_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLWriter_GetCompressor_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkDataCompressor GetCompressor()
		{
			vtkDataCompressor vtkDataCompressor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLWriter.vtkXMLWriter_GetCompressor_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataCompressor = (vtkDataCompressor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataCompressor.Register(null);
				}
			}
			return vtkDataCompressor;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLWriter_GetDataMode_06(HandleRef pThis);

		public virtual int GetDataMode()
		{
			return vtkXMLWriter.vtkXMLWriter_GetDataMode_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLWriter_GetDefaultFileExtension_07(HandleRef pThis);

		public virtual string GetDefaultFileExtension()
		{
			return Marshal.PtrToStringAnsi(vtkXMLWriter.vtkXMLWriter_GetDefaultFileExtension_07(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLWriter_GetEncodeAppendedData_08(HandleRef pThis);

		public virtual int GetEncodeAppendedData()
		{
			return vtkXMLWriter.vtkXMLWriter_GetEncodeAppendedData_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLWriter_GetFileName_09(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkXMLWriter.vtkXMLWriter_GetFileName_09(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLWriter_GetIdType_10(HandleRef pThis);

		public virtual int GetIdType()
		{
			return vtkXMLWriter.vtkXMLWriter_GetIdType_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLWriter_GetInput_11(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetInput(int port)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLWriter.vtkXMLWriter_GetInput_11(base.GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLWriter_GetInput_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkDataObject GetInput()
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLWriter.vtkXMLWriter_GetInput_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLWriter_GetNumberOfTimeSteps_13(HandleRef pThis);

		public virtual int GetNumberOfTimeSteps()
		{
			return vtkXMLWriter.vtkXMLWriter_GetNumberOfTimeSteps_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLWriter_GetTimeStep_14(HandleRef pThis);

		public virtual int GetTimeStep()
		{
			return vtkXMLWriter.vtkXMLWriter_GetTimeStep_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLWriter_GetTimeStepRange_15(HandleRef pThis);

		public virtual int[] GetTimeStepRange()
		{
			IntPtr intPtr = vtkXMLWriter.vtkXMLWriter_GetTimeStepRange_15(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_GetTimeStepRange_16(HandleRef pThis, ref int _arg1, ref int _arg2);

		public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
		{
			vtkXMLWriter.vtkXMLWriter_GetTimeStepRange_16(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_GetTimeStepRange_17(HandleRef pThis, IntPtr _arg);

		public virtual void GetTimeStepRange(IntPtr _arg)
		{
			vtkXMLWriter.vtkXMLWriter_GetTimeStepRange_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLWriter_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkXMLWriter.vtkXMLWriter_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLWriter_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkXMLWriter.vtkXMLWriter_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLWriter_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkXMLWriter NewInstance()
		{
			vtkXMLWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLWriter.vtkXMLWriter_NewInstance_20(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkXMLWriter_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkXMLWriter SafeDownCast(vtkObjectBase o)
		{
			vtkXMLWriter vtkXMLWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkXMLWriter.vtkXMLWriter_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLWriter = (vtkXMLWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLWriter.Register(null);
				}
			}
			return vtkXMLWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetBlockSize_22(HandleRef pThis, uint blockSize);

		public virtual void SetBlockSize(uint blockSize)
		{
			vtkXMLWriter.vtkXMLWriter_SetBlockSize_22(base.GetCppThis(), blockSize);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetByteOrder_23(HandleRef pThis, int _arg);

		public virtual void SetByteOrder(int _arg)
		{
			vtkXMLWriter.vtkXMLWriter_SetByteOrder_23(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetByteOrderToBigEndian_24(HandleRef pThis);

		public void SetByteOrderToBigEndian()
		{
			vtkXMLWriter.vtkXMLWriter_SetByteOrderToBigEndian_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetByteOrderToLittleEndian_25(HandleRef pThis);

		public void SetByteOrderToLittleEndian()
		{
			vtkXMLWriter.vtkXMLWriter_SetByteOrderToLittleEndian_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetCompressor_26(HandleRef pThis, HandleRef arg0);

		public virtual void SetCompressor(vtkDataCompressor arg0)
		{
			vtkXMLWriter.vtkXMLWriter_SetCompressor_26(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetCompressorType_27(HandleRef pThis, int compressorType);

		public void SetCompressorType(int compressorType)
		{
			vtkXMLWriter.vtkXMLWriter_SetCompressorType_27(base.GetCppThis(), compressorType);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetCompressorTypeToNone_28(HandleRef pThis);

		public void SetCompressorTypeToNone()
		{
			vtkXMLWriter.vtkXMLWriter_SetCompressorTypeToNone_28(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetCompressorTypeToZLib_29(HandleRef pThis);

		public void SetCompressorTypeToZLib()
		{
			vtkXMLWriter.vtkXMLWriter_SetCompressorTypeToZLib_29(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetDataMode_30(HandleRef pThis, int _arg);

		public virtual void SetDataMode(int _arg)
		{
			vtkXMLWriter.vtkXMLWriter_SetDataMode_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetDataModeToAppended_31(HandleRef pThis);

		public void SetDataModeToAppended()
		{
			vtkXMLWriter.vtkXMLWriter_SetDataModeToAppended_31(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetDataModeToAscii_32(HandleRef pThis);

		public void SetDataModeToAscii()
		{
			vtkXMLWriter.vtkXMLWriter_SetDataModeToAscii_32(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetDataModeToBinary_33(HandleRef pThis);

		public void SetDataModeToBinary()
		{
			vtkXMLWriter.vtkXMLWriter_SetDataModeToBinary_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetEncodeAppendedData_34(HandleRef pThis, int _arg);

		public virtual void SetEncodeAppendedData(int _arg)
		{
			vtkXMLWriter.vtkXMLWriter_SetEncodeAppendedData_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetFileName_35(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkXMLWriter.vtkXMLWriter_SetFileName_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetIdType_36(HandleRef pThis, int arg0);

		public virtual void SetIdType(int arg0)
		{
			vtkXMLWriter.vtkXMLWriter_SetIdType_36(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetIdTypeToInt32_37(HandleRef pThis);

		public void SetIdTypeToInt32()
		{
			vtkXMLWriter.vtkXMLWriter_SetIdTypeToInt32_37(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetIdTypeToInt64_38(HandleRef pThis);

		public void SetIdTypeToInt64()
		{
			vtkXMLWriter.vtkXMLWriter_SetIdTypeToInt64_38(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetInput_39(HandleRef pThis, HandleRef arg0);

		public void SetInput(vtkDataObject arg0)
		{
			vtkXMLWriter.vtkXMLWriter_SetInput_39(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetInput_40(HandleRef pThis, int arg0, HandleRef arg1);

		public void SetInput(int arg0, vtkDataObject arg1)
		{
			vtkXMLWriter.vtkXMLWriter_SetInput_40(base.GetCppThis(), arg0, (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetNumberOfTimeSteps_41(HandleRef pThis, int _arg);

		public virtual void SetNumberOfTimeSteps(int _arg)
		{
			vtkXMLWriter.vtkXMLWriter_SetNumberOfTimeSteps_41(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetTimeStep_42(HandleRef pThis, int _arg);

		public virtual void SetTimeStep(int _arg)
		{
			vtkXMLWriter.vtkXMLWriter_SetTimeStep_42(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetTimeStepRange_43(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetTimeStepRange(int _arg1, int _arg2)
		{
			vtkXMLWriter.vtkXMLWriter_SetTimeStepRange_43(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_SetTimeStepRange_44(HandleRef pThis, IntPtr _arg);

		public void SetTimeStepRange(IntPtr _arg)
		{
			vtkXMLWriter.vtkXMLWriter_SetTimeStepRange_44(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_Start_45(HandleRef pThis);

		public void Start()
		{
			vtkXMLWriter.vtkXMLWriter_Start_45(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_Stop_46(HandleRef pThis);

		public void Stop()
		{
			vtkXMLWriter.vtkXMLWriter_Stop_46(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkXMLWriter_Write_47(HandleRef pThis);

		public int Write()
		{
			return vtkXMLWriter.vtkXMLWriter_Write_47(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkXMLWriter_WriteNextTime_48(HandleRef pThis, double time);

		public void WriteNextTime(double time)
		{
			vtkXMLWriter.vtkXMLWriter_WriteNextTime_48(base.GetCppThis(), time);
		}
	}
}
