using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoTerrain2D : vtkGeoTerrain
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoTerrain2D";

		public new static readonly string MRClassNameKey;

		static vtkGeoTerrain2D()
		{
			vtkGeoTerrain2D.MRClassNameKey = "class vtkGeoTerrain2D";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoTerrain2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoTerrain2D"));
		}

		public vtkGeoTerrain2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrain2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoTerrain2D New()
		{
			vtkGeoTerrain2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTerrain2D.vtkGeoTerrain2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoTerrain2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoTerrain2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoTerrain2D.vtkGeoTerrain2D_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoTerrain2D_GetLocationTolerance_01(HandleRef pThis);

		public virtual double GetLocationTolerance()
		{
			return vtkGeoTerrain2D.vtkGeoTerrain2D_GetLocationTolerance_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoTerrain2D_GetTextureTolerance_02(HandleRef pThis);

		public virtual double GetTextureTolerance()
		{
			return vtkGeoTerrain2D.vtkGeoTerrain2D_GetTextureTolerance_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrain2D_GetTransform_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTerrain2D.vtkGeoTerrain2D_GetTransform_03(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTerrain2D_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoTerrain2D.vtkGeoTerrain2D_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoTerrain2D_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoTerrain2D.vtkGeoTerrain2D_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrain2D_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoTerrain2D NewInstance()
		{
			vtkGeoTerrain2D result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTerrain2D.vtkGeoTerrain2D_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoTerrain2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoTerrain2D_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoTerrain2D SafeDownCast(vtkObjectBase o)
		{
			vtkGeoTerrain2D vtkGeoTerrain2D = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoTerrain2D.vtkGeoTerrain2D_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoTerrain2D = (vtkGeoTerrain2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoTerrain2D.Register(null);
				}
			}
			return vtkGeoTerrain2D;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrain2D_SetLocationTolerance_09(HandleRef pThis, double _arg);

		public virtual void SetLocationTolerance(double _arg)
		{
			vtkGeoTerrain2D.vtkGeoTerrain2D_SetLocationTolerance_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoTerrain2D_SetTextureTolerance_10(HandleRef pThis, double _arg);

		public virtual void SetTextureTolerance(double _arg)
		{
			vtkGeoTerrain2D.vtkGeoTerrain2D_SetTextureTolerance_10(base.GetCppThis(), _arg);
		}
	}
}
