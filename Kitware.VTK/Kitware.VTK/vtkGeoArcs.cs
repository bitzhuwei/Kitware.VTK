using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoArcs : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoArcs";

		public new static readonly string MRClassNameKey;

		static vtkGeoArcs()
		{
			vtkGeoArcs.MRClassNameKey = "class vtkGeoArcs";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoArcs.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoArcs"));
		}

		public vtkGeoArcs(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoArcs_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoArcs New()
		{
			vtkGeoArcs result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoArcs.vtkGeoArcs_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoArcs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoArcs() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoArcs.vtkGeoArcs_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoArcs_GetExplodeFactor_01(HandleRef pThis);

		public virtual double GetExplodeFactor()
		{
			return vtkGeoArcs.vtkGeoArcs_GetExplodeFactor_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern double vtkGeoArcs_GetGlobeRadius_02(HandleRef pThis);

		public virtual double GetGlobeRadius()
		{
			return vtkGeoArcs.vtkGeoArcs_GetGlobeRadius_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoArcs_GetNumberOfSubdivisions_03(HandleRef pThis);

		public virtual int GetNumberOfSubdivisions()
		{
			return vtkGeoArcs.vtkGeoArcs_GetNumberOfSubdivisions_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoArcs_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoArcs.vtkGeoArcs_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern int vtkGeoArcs_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoArcs.vtkGeoArcs_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoArcs_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoArcs NewInstance()
		{
			vtkGeoArcs result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoArcs.vtkGeoArcs_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoArcs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoArcs_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoArcs SafeDownCast(vtkObjectBase o)
		{
			vtkGeoArcs vtkGeoArcs = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoArcs.vtkGeoArcs_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoArcs = (vtkGeoArcs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoArcs.Register(null);
				}
			}
			return vtkGeoArcs;
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoArcs_SetExplodeFactor_09(HandleRef pThis, double _arg);

		public virtual void SetExplodeFactor(double _arg)
		{
			vtkGeoArcs.vtkGeoArcs_SetExplodeFactor_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoArcs_SetGlobeRadius_10(HandleRef pThis, double _arg);

		public virtual void SetGlobeRadius(double _arg)
		{
			vtkGeoArcs.vtkGeoArcs_SetGlobeRadius_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGeovis.Unmanaged.dll")]
		internal static extern void vtkGeoArcs_SetNumberOfSubdivisions_11(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSubdivisions(int _arg)
		{
			vtkGeoArcs.vtkGeoArcs_SetNumberOfSubdivisions_11(base.GetCppThis(), _arg);
		}
	}
}
