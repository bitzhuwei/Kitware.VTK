using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkVolumeReader : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeReader";

		public new static readonly string MRClassNameKey;

		static vtkVolumeReader()
		{
			vtkVolumeReader.MRClassNameKey = "class vtkVolumeReader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeReader"));
		}

		public vtkVolumeReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeReader_GetDataOrigin_01(HandleRef pThis);

		public virtual double[] GetDataOrigin()
		{
			IntPtr intPtr = vtkVolumeReader.vtkVolumeReader_GetDataOrigin_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolumeReader_GetDataOrigin_02(HandleRef pThis, IntPtr data);

		public virtual void GetDataOrigin(IntPtr data)
		{
			vtkVolumeReader.vtkVolumeReader_GetDataOrigin_02(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeReader_GetDataSpacing_03(HandleRef pThis);

		public virtual double[] GetDataSpacing()
		{
			IntPtr intPtr = vtkVolumeReader.vtkVolumeReader_GetDataSpacing_03(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolumeReader_GetDataSpacing_04(HandleRef pThis, IntPtr data);

		public virtual void GetDataSpacing(IntPtr data)
		{
			vtkVolumeReader.vtkVolumeReader_GetDataSpacing_04(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeReader_GetFilePattern_05(HandleRef pThis);

		public virtual string GetFilePattern()
		{
			return Marshal.PtrToStringAnsi(vtkVolumeReader.vtkVolumeReader_GetFilePattern_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeReader_GetFilePrefix_06(HandleRef pThis);

		public virtual string GetFilePrefix()
		{
			return Marshal.PtrToStringAnsi(vtkVolumeReader.vtkVolumeReader_GetFilePrefix_06(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeReader_GetImage_07(HandleRef pThis, int ImageNumber, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetImage(int ImageNumber)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeReader.vtkVolumeReader_GetImage_07(base.GetCppThis(), ImageNumber, ref mteStatus, ref mteIndex, ref rawRefCount);
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
		internal static extern IntPtr vtkVolumeReader_GetImageRange_08(HandleRef pThis);

		public virtual int[] GetImageRange()
		{
			IntPtr intPtr = vtkVolumeReader.vtkVolumeReader_GetImageRange_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolumeReader_GetImageRange_09(HandleRef pThis, IntPtr data);

		public virtual void GetImageRange(IntPtr data)
		{
			vtkVolumeReader.vtkVolumeReader_GetImageRange_09(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkVolumeReader_IsA_10(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkVolumeReader.vtkVolumeReader_IsA_10(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkVolumeReader_IsTypeOf_11(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkVolumeReader.vtkVolumeReader_IsTypeOf_11(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeReader_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkVolumeReader NewInstance()
		{
			vtkVolumeReader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeReader.vtkVolumeReader_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkVolumeReader_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkVolumeReader SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeReader vtkVolumeReader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkVolumeReader.vtkVolumeReader_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeReader = (vtkVolumeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeReader.Register(null);
				}
			}
			return vtkVolumeReader;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolumeReader_SetDataOrigin_14(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDataOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkVolumeReader.vtkVolumeReader_SetDataOrigin_14(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolumeReader_SetDataOrigin_15(HandleRef pThis, IntPtr _arg);

		public virtual void SetDataOrigin(IntPtr _arg)
		{
			vtkVolumeReader.vtkVolumeReader_SetDataOrigin_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolumeReader_SetDataSpacing_16(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetDataSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkVolumeReader.vtkVolumeReader_SetDataSpacing_16(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolumeReader_SetDataSpacing_17(HandleRef pThis, IntPtr _arg);

		public virtual void SetDataSpacing(IntPtr _arg)
		{
			vtkVolumeReader.vtkVolumeReader_SetDataSpacing_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolumeReader_SetFilePattern_18(HandleRef pThis, string _arg);

		public virtual void SetFilePattern(string _arg)
		{
			vtkVolumeReader.vtkVolumeReader_SetFilePattern_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolumeReader_SetFilePrefix_19(HandleRef pThis, string _arg);

		public virtual void SetFilePrefix(string _arg)
		{
			vtkVolumeReader.vtkVolumeReader_SetFilePrefix_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolumeReader_SetImageRange_20(HandleRef pThis, int _arg1, int _arg2);

		public virtual void SetImageRange(int _arg1, int _arg2)
		{
			vtkVolumeReader.vtkVolumeReader_SetImageRange_20(base.GetCppThis(), _arg1, _arg2);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkVolumeReader_SetImageRange_21(HandleRef pThis, IntPtr _arg);

		public void SetImageRange(IntPtr _arg)
		{
			vtkVolumeReader.vtkVolumeReader_SetImageRange_21(base.GetCppThis(), _arg);
		}
	}
}
