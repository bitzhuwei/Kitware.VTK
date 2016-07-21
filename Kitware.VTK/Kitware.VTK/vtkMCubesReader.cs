using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMCubesReader : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMCubesReader";

		public new static readonly string MRClassNameKey;

		static vtkMCubesReader()
		{
			vtkMCubesReader.MRClassNameKey = "class vtkMCubesReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMCubesReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMCubesReader"));
		}

		public vtkMCubesReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMCubesReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMCubesReader New()
		{
			vtkMCubesReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMCubesReader.vtkMCubesReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMCubesReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMCubesReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMCubesReader.vtkMCubesReader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_CreateDefaultLocator_01(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkMCubesReader.vtkMCubesReader_CreateDefaultLocator_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_FlipNormalsOff_02(HandleRef pThis);

		public virtual void FlipNormalsOff()
		{
			vtkMCubesReader.vtkMCubesReader_FlipNormalsOff_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_FlipNormalsOn_03(HandleRef pThis);

		public virtual void FlipNormalsOn()
		{
			vtkMCubesReader.vtkMCubesReader_FlipNormalsOn_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMCubesReader_GetDataByteOrder_04(HandleRef pThis);

		public int GetDataByteOrder()
		{
			return vtkMCubesReader.vtkMCubesReader_GetDataByteOrder_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMCubesReader_GetDataByteOrderAsString_05(HandleRef pThis);

		public string GetDataByteOrderAsString()
		{
			return Marshal.PtrToStringAnsi(vtkMCubesReader.vtkMCubesReader_GetDataByteOrderAsString_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMCubesReader_GetFileName_06(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkMCubesReader.vtkMCubesReader_GetFileName_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMCubesReader_GetFlipNormals_07(HandleRef pThis);

		public virtual int GetFlipNormals()
		{
			return vtkMCubesReader.vtkMCubesReader_GetFlipNormals_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMCubesReader_GetHeaderSize_08(HandleRef pThis);

		public virtual int GetHeaderSize()
		{
			return vtkMCubesReader.vtkMCubesReader_GetHeaderSize_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMCubesReader_GetHeaderSizeMaxValue_09(HandleRef pThis);

		public virtual int GetHeaderSizeMaxValue()
		{
			return vtkMCubesReader.vtkMCubesReader_GetHeaderSizeMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMCubesReader_GetHeaderSizeMinValue_10(HandleRef pThis);

		public virtual int GetHeaderSizeMinValue()
		{
			return vtkMCubesReader.vtkMCubesReader_GetHeaderSizeMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMCubesReader_GetLimitsFileName_11(HandleRef pThis);

		public virtual string GetLimitsFileName()
		{
			return Marshal.PtrToStringAnsi(vtkMCubesReader.vtkMCubesReader_GetLimitsFileName_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMCubesReader_GetLocator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMCubesReader.vtkMCubesReader_GetLocator_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkMCubesReader_GetMTime_13(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkMCubesReader.vtkMCubesReader_GetMTime_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMCubesReader_GetNormals_14(HandleRef pThis);

		public virtual int GetNormals()
		{
			return vtkMCubesReader.vtkMCubesReader_GetNormals_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMCubesReader_GetSwapBytes_15(HandleRef pThis);

		public virtual int GetSwapBytes()
		{
			return vtkMCubesReader.vtkMCubesReader_GetSwapBytes_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMCubesReader_IsA_16(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMCubesReader.vtkMCubesReader_IsA_16(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkMCubesReader_IsTypeOf_17(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMCubesReader.vtkMCubesReader_IsTypeOf_17(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMCubesReader_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMCubesReader NewInstance()
		{
			vtkMCubesReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMCubesReader.vtkMCubesReader_NewInstance_19(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMCubesReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_NormalsOff_20(HandleRef pThis);

		public virtual void NormalsOff()
		{
			vtkMCubesReader.vtkMCubesReader_NormalsOff_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_NormalsOn_21(HandleRef pThis);

		public virtual void NormalsOn()
		{
			vtkMCubesReader.vtkMCubesReader_NormalsOn_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkMCubesReader_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMCubesReader SafeDownCast(vtkObjectBase o)
		{
			vtkMCubesReader vtkMCubesReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMCubesReader.vtkMCubesReader_SafeDownCast_22((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMCubesReader = (vtkMCubesReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMCubesReader.Register(null);
				}
			}
			return vtkMCubesReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_SetDataByteOrder_23(HandleRef pThis, int arg0);

		public void SetDataByteOrder(int arg0)
		{
			vtkMCubesReader.vtkMCubesReader_SetDataByteOrder_23(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_SetDataByteOrderToBigEndian_24(HandleRef pThis);

		public void SetDataByteOrderToBigEndian()
		{
			vtkMCubesReader.vtkMCubesReader_SetDataByteOrderToBigEndian_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_SetDataByteOrderToLittleEndian_25(HandleRef pThis);

		public void SetDataByteOrderToLittleEndian()
		{
			vtkMCubesReader.vtkMCubesReader_SetDataByteOrderToLittleEndian_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_SetFileName_26(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkMCubesReader.vtkMCubesReader_SetFileName_26(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_SetFlipNormals_27(HandleRef pThis, int _arg);

		public virtual void SetFlipNormals(int _arg)
		{
			vtkMCubesReader.vtkMCubesReader_SetFlipNormals_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_SetHeaderSize_28(HandleRef pThis, int _arg);

		public virtual void SetHeaderSize(int _arg)
		{
			vtkMCubesReader.vtkMCubesReader_SetHeaderSize_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_SetLimitsFileName_29(HandleRef pThis, string _arg);

		public virtual void SetLimitsFileName(string _arg)
		{
			vtkMCubesReader.vtkMCubesReader_SetLimitsFileName_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_SetLocator_30(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkMCubesReader.vtkMCubesReader_SetLocator_30(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_SetNormals_31(HandleRef pThis, int _arg);

		public virtual void SetNormals(int _arg)
		{
			vtkMCubesReader.vtkMCubesReader_SetNormals_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_SetSwapBytes_32(HandleRef pThis, int _arg);

		public virtual void SetSwapBytes(int _arg)
		{
			vtkMCubesReader.vtkMCubesReader_SetSwapBytes_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_SwapBytesOff_33(HandleRef pThis);

		public virtual void SwapBytesOff()
		{
			vtkMCubesReader.vtkMCubesReader_SwapBytesOff_33(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkMCubesReader_SwapBytesOn_34(HandleRef pThis);

		public virtual void SwapBytesOn()
		{
			vtkMCubesReader.vtkMCubesReader_SwapBytesOn_34(base.GetCppThis());
		}
	}
}
