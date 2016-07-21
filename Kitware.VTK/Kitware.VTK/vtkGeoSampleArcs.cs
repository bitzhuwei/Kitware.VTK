using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoSampleArcs : vtkPolyDataAlgorithm
	{
		public enum RECTANGULAR_WrapperEnum
		{
			RECTANGULAR,
			SPHERICAL
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoSampleArcs";

		public new static readonly string MRClassNameKey;

		static vtkGeoSampleArcs()
		{
			vtkGeoSampleArcs.MRClassNameKey = "class vtkGeoSampleArcs";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoSampleArcs.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoSampleArcs"));
		}

		public vtkGeoSampleArcs(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoSampleArcs_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoSampleArcs New()
		{
			vtkGeoSampleArcs result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoSampleArcs.vtkGeoSampleArcs_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoSampleArcs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoSampleArcs() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoSampleArcs.vtkGeoSampleArcs_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoSampleArcs_GetGlobeRadius_01(HandleRef pThis);

		public virtual double GetGlobeRadius()
		{
			return vtkGeoSampleArcs.vtkGeoSampleArcs_GetGlobeRadius_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoSampleArcs_GetInputCoordinateSystem_02(HandleRef pThis);

		public virtual int GetInputCoordinateSystem()
		{
			return vtkGeoSampleArcs.vtkGeoSampleArcs_GetInputCoordinateSystem_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoSampleArcs_GetMaximumDistanceMeters_03(HandleRef pThis);

		public virtual double GetMaximumDistanceMeters()
		{
			return vtkGeoSampleArcs.vtkGeoSampleArcs_GetMaximumDistanceMeters_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoSampleArcs_GetOutputCoordinateSystem_04(HandleRef pThis);

		public virtual int GetOutputCoordinateSystem()
		{
			return vtkGeoSampleArcs.vtkGeoSampleArcs_GetOutputCoordinateSystem_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoSampleArcs_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoSampleArcs.vtkGeoSampleArcs_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoSampleArcs_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoSampleArcs.vtkGeoSampleArcs_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoSampleArcs_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoSampleArcs NewInstance()
		{
			vtkGeoSampleArcs result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoSampleArcs.vtkGeoSampleArcs_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoSampleArcs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoSampleArcs_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoSampleArcs SafeDownCast(vtkObjectBase o)
		{
			vtkGeoSampleArcs vtkGeoSampleArcs = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoSampleArcs.vtkGeoSampleArcs_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoSampleArcs = (vtkGeoSampleArcs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoSampleArcs.Register(null);
				}
			}
			return vtkGeoSampleArcs;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSampleArcs_SetGlobeRadius_10(HandleRef pThis, double _arg);

		public virtual void SetGlobeRadius(double _arg)
		{
			vtkGeoSampleArcs.vtkGeoSampleArcs_SetGlobeRadius_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSampleArcs_SetInputCoordinateSystem_11(HandleRef pThis, int _arg);

		public virtual void SetInputCoordinateSystem(int _arg)
		{
			vtkGeoSampleArcs.vtkGeoSampleArcs_SetInputCoordinateSystem_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSampleArcs_SetInputCoordinateSystemToRectangular_12(HandleRef pThis);

		public virtual void SetInputCoordinateSystemToRectangular()
		{
			vtkGeoSampleArcs.vtkGeoSampleArcs_SetInputCoordinateSystemToRectangular_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSampleArcs_SetInputCoordinateSystemToSpherical_13(HandleRef pThis);

		public virtual void SetInputCoordinateSystemToSpherical()
		{
			vtkGeoSampleArcs.vtkGeoSampleArcs_SetInputCoordinateSystemToSpherical_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSampleArcs_SetMaximumDistanceMeters_14(HandleRef pThis, double _arg);

		public virtual void SetMaximumDistanceMeters(double _arg)
		{
			vtkGeoSampleArcs.vtkGeoSampleArcs_SetMaximumDistanceMeters_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSampleArcs_SetOutputCoordinateSystem_15(HandleRef pThis, int _arg);

		public virtual void SetOutputCoordinateSystem(int _arg)
		{
			vtkGeoSampleArcs.vtkGeoSampleArcs_SetOutputCoordinateSystem_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSampleArcs_SetOutputCoordinateSystemToRectangular_16(HandleRef pThis);

		public virtual void SetOutputCoordinateSystemToRectangular()
		{
			vtkGeoSampleArcs.vtkGeoSampleArcs_SetOutputCoordinateSystemToRectangular_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoSampleArcs_SetOutputCoordinateSystemToSpherical_17(HandleRef pThis);

		public virtual void SetOutputCoordinateSystemToSpherical()
		{
			vtkGeoSampleArcs.vtkGeoSampleArcs_SetOutputCoordinateSystemToSpherical_17(base.GetCppThis());
		}
	}
}
