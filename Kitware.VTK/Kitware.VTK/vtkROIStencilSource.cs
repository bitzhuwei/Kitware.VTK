using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkROIStencilSource : vtkImageStencilSource
	{
		public enum BOX_WrapperEnum
		{
			BOX,
			CYLINDERX = 2,
			CYLINDERY,
			CYLINDERZ,
			ELLIPSOID = 1
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkROIStencilSource";

		public new static readonly string MRClassNameKey;

		static vtkROIStencilSource()
		{
			vtkROIStencilSource.MRClassNameKey = "class vtkROIStencilSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkROIStencilSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkROIStencilSource"));
		}

		public vtkROIStencilSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkROIStencilSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkROIStencilSource New()
		{
			vtkROIStencilSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkROIStencilSource.vtkROIStencilSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkROIStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkROIStencilSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkROIStencilSource.vtkROIStencilSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkROIStencilSource_GetBounds_01(HandleRef pThis);

		public virtual double[] GetBounds()
		{
			IntPtr intPtr = vtkROIStencilSource.vtkROIStencilSource_GetBounds_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkROIStencilSource_GetBounds_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6);

		public virtual void GetBounds(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4, ref double _arg5, ref double _arg6)
		{
			vtkROIStencilSource.vtkROIStencilSource_GetBounds_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkROIStencilSource_GetBounds_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetBounds(IntPtr _arg)
		{
			vtkROIStencilSource.vtkROIStencilSource_GetBounds_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkROIStencilSource_GetShape_04(HandleRef pThis);

		public virtual int GetShape()
		{
			return vtkROIStencilSource.vtkROIStencilSource_GetShape_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkROIStencilSource_GetShapeAsString_05(HandleRef pThis);

		public virtual string GetShapeAsString()
		{
			return Marshal.PtrToStringAnsi(vtkROIStencilSource.vtkROIStencilSource_GetShapeAsString_05(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkROIStencilSource_GetShapeMaxValue_06(HandleRef pThis);

		public virtual int GetShapeMaxValue()
		{
			return vtkROIStencilSource.vtkROIStencilSource_GetShapeMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkROIStencilSource_GetShapeMinValue_07(HandleRef pThis);

		public virtual int GetShapeMinValue()
		{
			return vtkROIStencilSource.vtkROIStencilSource_GetShapeMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkROIStencilSource_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkROIStencilSource.vtkROIStencilSource_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkROIStencilSource_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkROIStencilSource.vtkROIStencilSource_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkROIStencilSource_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkROIStencilSource NewInstance()
		{
			vtkROIStencilSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkROIStencilSource.vtkROIStencilSource_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkROIStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkROIStencilSource_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkROIStencilSource SafeDownCast(vtkObjectBase o)
		{
			vtkROIStencilSource vtkROIStencilSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkROIStencilSource.vtkROIStencilSource_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkROIStencilSource = (vtkROIStencilSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkROIStencilSource.Register(null);
				}
			}
			return vtkROIStencilSource;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkROIStencilSource_SetBounds_13(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

		public virtual void SetBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
		{
			vtkROIStencilSource.vtkROIStencilSource_SetBounds_13(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkROIStencilSource_SetBounds_14(HandleRef pThis, IntPtr _arg);

		public virtual void SetBounds(IntPtr _arg)
		{
			vtkROIStencilSource.vtkROIStencilSource_SetBounds_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkROIStencilSource_SetShape_15(HandleRef pThis, int _arg);

		public virtual void SetShape(int _arg)
		{
			vtkROIStencilSource.vtkROIStencilSource_SetShape_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkROIStencilSource_SetShapeToBox_16(HandleRef pThis);

		public void SetShapeToBox()
		{
			vtkROIStencilSource.vtkROIStencilSource_SetShapeToBox_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkROIStencilSource_SetShapeToCylinderX_17(HandleRef pThis);

		public void SetShapeToCylinderX()
		{
			vtkROIStencilSource.vtkROIStencilSource_SetShapeToCylinderX_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkROIStencilSource_SetShapeToCylinderY_18(HandleRef pThis);

		public void SetShapeToCylinderY()
		{
			vtkROIStencilSource.vtkROIStencilSource_SetShapeToCylinderY_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkROIStencilSource_SetShapeToCylinderZ_19(HandleRef pThis);

		public void SetShapeToCylinderZ()
		{
			vtkROIStencilSource.vtkROIStencilSource_SetShapeToCylinderZ_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkROIStencilSource_SetShapeToEllipsoid_20(HandleRef pThis);

		public void SetShapeToEllipsoid()
		{
			vtkROIStencilSource.vtkROIStencilSource_SetShapeToEllipsoid_20(base.GetCppThis());
		}
	}
}
