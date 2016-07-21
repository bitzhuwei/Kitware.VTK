using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageStencilSource : vtkImageStencilAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageStencilSource";

		public new static readonly string MRClassNameKey;

		static vtkImageStencilSource()
		{
			vtkImageStencilSource.MRClassNameKey = "class vtkImageStencilSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageStencilSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageStencilSource"));
		}

		public vtkImageStencilSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageStencilSource New()
		{
			vtkImageStencilSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencilSource.vtkImageStencilSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageStencilSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageStencilSource.vtkImageStencilSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilSource_GetInformationInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkImageData GetInformationInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencilSource.vtkImageStencilSource_GetInformationInput_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilSource_GetOutputOrigin_02(HandleRef pThis);

		public virtual double[] GetOutputOrigin()
		{
			IntPtr intPtr = vtkImageStencilSource.vtkImageStencilSource_GetOutputOrigin_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilSource_GetOutputOrigin_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOutputOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageStencilSource.vtkImageStencilSource_GetOutputOrigin_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilSource_GetOutputOrigin_04(HandleRef pThis, IntPtr _arg);

		public virtual void GetOutputOrigin(IntPtr _arg)
		{
			vtkImageStencilSource.vtkImageStencilSource_GetOutputOrigin_04(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilSource_GetOutputSpacing_05(HandleRef pThis);

		public virtual double[] GetOutputSpacing()
		{
			IntPtr intPtr = vtkImageStencilSource.vtkImageStencilSource_GetOutputSpacing_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilSource_GetOutputSpacing_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		public virtual void GetOutputSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageStencilSource.vtkImageStencilSource_GetOutputSpacing_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilSource_GetOutputSpacing_07(HandleRef pThis, IntPtr _arg);

		public virtual void GetOutputSpacing(IntPtr _arg)
		{
			vtkImageStencilSource.vtkImageStencilSource_GetOutputSpacing_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilSource_GetOutputWholeExtent_08(HandleRef pThis);

		public virtual int[] GetOutputWholeExtent()
		{
			IntPtr intPtr = vtkImageStencilSource.vtkImageStencilSource_GetOutputWholeExtent_08(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilSource_GetOutputWholeExtent_09(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		public virtual void GetOutputWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageStencilSource.vtkImageStencilSource_GetOutputWholeExtent_09(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilSource_GetOutputWholeExtent_10(HandleRef pThis, IntPtr _arg);

		public virtual void GetOutputWholeExtent(IntPtr _arg)
		{
			vtkImageStencilSource.vtkImageStencilSource_GetOutputWholeExtent_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageStencilSource_IsA_11(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageStencilSource.vtkImageStencilSource_IsA_11(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageStencilSource_IsTypeOf_12(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageStencilSource.vtkImageStencilSource_IsTypeOf_12(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilSource_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageStencilSource NewInstance()
		{
			vtkImageStencilSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencilSource.vtkImageStencilSource_NewInstance_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilSource_ReportReferences_15(HandleRef pThis, HandleRef arg0);

		public virtual void ReportReferences(vtkGarbageCollector arg0)
		{
			vtkImageStencilSource.vtkImageStencilSource_ReportReferences_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageStencilSource_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageStencilSource SafeDownCast(vtkObjectBase o)
		{
			vtkImageStencilSource vtkImageStencilSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageStencilSource.vtkImageStencilSource_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilSource = (vtkImageStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilSource.Register(null);
				}
			}
			return vtkImageStencilSource;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilSource_SetInformationInput_17(HandleRef pThis, HandleRef arg0);

		public virtual void SetInformationInput(vtkImageData arg0)
		{
			vtkImageStencilSource.vtkImageStencilSource_SetInformationInput_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilSource_SetOutputOrigin_18(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOutputOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkImageStencilSource.vtkImageStencilSource_SetOutputOrigin_18(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilSource_SetOutputOrigin_19(HandleRef pThis, IntPtr _arg);

		public virtual void SetOutputOrigin(IntPtr _arg)
		{
			vtkImageStencilSource.vtkImageStencilSource_SetOutputOrigin_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilSource_SetOutputSpacing_20(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetOutputSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkImageStencilSource.vtkImageStencilSource_SetOutputSpacing_20(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilSource_SetOutputSpacing_21(HandleRef pThis, IntPtr _arg);

		public virtual void SetOutputSpacing(IntPtr _arg)
		{
			vtkImageStencilSource.vtkImageStencilSource_SetOutputSpacing_21(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilSource_SetOutputWholeExtent_22(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		public virtual void SetOutputWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkImageStencilSource.vtkImageStencilSource_SetOutputWholeExtent_22(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageStencilSource_SetOutputWholeExtent_23(HandleRef pThis, IntPtr _arg);

		public virtual void SetOutputWholeExtent(IntPtr _arg)
		{
			vtkImageStencilSource.vtkImageStencilSource_SetOutputWholeExtent_23(base.GetCppThis(), _arg);
		}
	}
}
