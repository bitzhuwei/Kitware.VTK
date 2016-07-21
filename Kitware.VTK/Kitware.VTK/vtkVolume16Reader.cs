using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkVolume16Reader : vtkVolumeReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolume16Reader";

		public new static readonly string MRClassNameKey;

		static vtkVolume16Reader()
		{
			vtkVolume16Reader.MRClassNameKey = "class vtkVolume16Reader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolume16Reader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolume16Reader"));
		}

		public vtkVolume16Reader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume16Reader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolume16Reader New()
		{
			vtkVolume16Reader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolume16Reader.vtkVolume16Reader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolume16Reader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkVolume16Reader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkVolume16Reader.vtkVolume16Reader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkVolume16Reader_GetDataByteOrder_01(HandleRef pThis);

		public int GetDataByteOrder()
		{
			return vtkVolume16Reader.vtkVolume16Reader_GetDataByteOrder_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume16Reader_GetDataByteOrderAsString_02(HandleRef pThis);

		public string GetDataByteOrderAsString()
		{
			return Marshal.PtrToStringAnsi(vtkVolume16Reader.vtkVolume16Reader_GetDataByteOrderAsString_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume16Reader_GetDataDimensions_03(HandleRef pThis);

		public virtual int[] GetDataDimensions()
		{
			IntPtr intPtr = vtkVolume16Reader.vtkVolume16Reader_GetDataDimensions_03(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolume16Reader_GetDataDimensions_04(HandleRef pThis, IntPtr data);

		public virtual void GetDataDimensions(IntPtr data)
		{
			vtkVolume16Reader.vtkVolume16Reader_GetDataDimensions_04(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern ushort vtkVolume16Reader_GetDataMask_05(HandleRef pThis);

		public virtual ushort GetDataMask()
		{
			return vtkVolume16Reader.vtkVolume16Reader_GetDataMask_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkVolume16Reader_GetHeaderSize_06(HandleRef pThis);

		public virtual int GetHeaderSize()
		{
			return vtkVolume16Reader.vtkVolume16Reader_GetHeaderSize_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume16Reader_GetImage_07(HandleRef pThis, int ImageNumber, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkImageData GetImage(int ImageNumber)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolume16Reader.vtkVolume16Reader_GetImage_07(base.GetCppThis(), ImageNumber, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkVolume16Reader_GetSwapBytes_08(HandleRef pThis);

		public virtual int GetSwapBytes()
		{
			return vtkVolume16Reader.vtkVolume16Reader_GetSwapBytes_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume16Reader_GetTransform_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkTransform GetTransform()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolume16Reader.vtkVolume16Reader_GetTransform_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkVolume16Reader_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolume16Reader.vtkVolume16Reader_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkVolume16Reader_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolume16Reader.vtkVolume16Reader_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume16Reader_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolume16Reader NewInstance()
		{
			vtkVolume16Reader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolume16Reader.vtkVolume16Reader_NewInstance_13(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolume16Reader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkVolume16Reader_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolume16Reader SafeDownCast(vtkObjectBase o)
		{
			vtkVolume16Reader vtkVolume16Reader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolume16Reader.vtkVolume16Reader_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolume16Reader = (vtkVolume16Reader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolume16Reader.Register(null);
				}
			}
			return vtkVolume16Reader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolume16Reader_SetDataByteOrder_15(HandleRef pThis, int arg0);

		public void SetDataByteOrder(int arg0)
		{
			vtkVolume16Reader.vtkVolume16Reader_SetDataByteOrder_15(base.GetCppThis(), arg0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolume16Reader_SetDataByteOrderToBigEndian_16(HandleRef pThis);

		public void SetDataByteOrderToBigEndian()
		{
			vtkVolume16Reader.vtkVolume16Reader_SetDataByteOrderToBigEndian_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolume16Reader_SetDataByteOrderToLittleEndian_17(HandleRef pThis);

		public void SetDataByteOrderToLittleEndian()
		{
			vtkVolume16Reader.vtkVolume16Reader_SetDataByteOrderToLittleEndian_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolume16Reader_SetDataDimensions_18(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetDataDimensions(int _arg1, int _arg2)
		{
			vtkVolume16Reader.vtkVolume16Reader_SetDataDimensions_18(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolume16Reader_SetDataDimensions_19(HandleRef pThis, IntPtr _arg);

		public void SetDataDimensions(IntPtr _arg)
		{
			vtkVolume16Reader.vtkVolume16Reader_SetDataDimensions_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolume16Reader_SetDataMask_20(HandleRef pThis, ushort _arg);

		public virtual void SetDataMask(ushort _arg)
		{
			vtkVolume16Reader.vtkVolume16Reader_SetDataMask_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolume16Reader_SetHeaderSize_21(HandleRef pThis, int _arg);

		public virtual void SetHeaderSize(int _arg)
		{
			vtkVolume16Reader.vtkVolume16Reader_SetHeaderSize_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolume16Reader_SetSwapBytes_22(HandleRef pThis, int _arg);

		public virtual void SetSwapBytes(int _arg)
		{
			vtkVolume16Reader.vtkVolume16Reader_SetSwapBytes_22(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolume16Reader_SetTransform_23(HandleRef pThis, HandleRef arg0);

		public virtual void SetTransform(vtkTransform arg0)
		{
			vtkVolume16Reader.vtkVolume16Reader_SetTransform_23(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolume16Reader_SwapBytesOff_24(HandleRef pThis);

		public virtual void SwapBytesOff()
		{
			vtkVolume16Reader.vtkVolume16Reader_SwapBytesOff_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolume16Reader_SwapBytesOn_25(HandleRef pThis);

		public virtual void SwapBytesOn()
		{
			vtkVolume16Reader.vtkVolume16Reader_SwapBytesOn_25(base.GetCppThis());
		}
	}
}
