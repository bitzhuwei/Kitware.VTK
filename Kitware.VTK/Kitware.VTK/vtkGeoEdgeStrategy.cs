using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkGeoEdgeStrategy : vtkEdgeLayoutStrategy
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeoEdgeStrategy";

		public new static readonly string MRClassNameKey;

		static vtkGeoEdgeStrategy()
		{
			vtkGeoEdgeStrategy.MRClassNameKey = "class vtkGeoEdgeStrategy";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeoEdgeStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeoEdgeStrategy"));
		}

		public vtkGeoEdgeStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoEdgeStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoEdgeStrategy New()
		{
			vtkGeoEdgeStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoEdgeStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkGeoEdgeStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkGeoEdgeStrategy_GetExplodeFactor_01(HandleRef pThis);

		public virtual double GetExplodeFactor()
		{
			return vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_GetExplodeFactor_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkGeoEdgeStrategy_GetGlobeRadius_02(HandleRef pThis);

		public virtual double GetGlobeRadius()
		{
			return vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_GetGlobeRadius_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGeoEdgeStrategy_GetNumberOfSubdivisions_03(HandleRef pThis);

		public virtual int GetNumberOfSubdivisions()
		{
			return vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_GetNumberOfSubdivisions_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGeoEdgeStrategy_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkGeoEdgeStrategy_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGeoEdgeStrategy_Layout_06(HandleRef pThis);

		public override void Layout()
		{
			vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_Layout_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoEdgeStrategy_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkGeoEdgeStrategy NewInstance()
		{
			vtkGeoEdgeStrategy result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeoEdgeStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkGeoEdgeStrategy_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkGeoEdgeStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkGeoEdgeStrategy vtkGeoEdgeStrategy = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeoEdgeStrategy = (vtkGeoEdgeStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeoEdgeStrategy.Register(null);
				}
			}
			return vtkGeoEdgeStrategy;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGeoEdgeStrategy_SetExplodeFactor_10(HandleRef pThis, double _arg);

		public virtual void SetExplodeFactor(double _arg)
		{
			vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_SetExplodeFactor_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGeoEdgeStrategy_SetGlobeRadius_11(HandleRef pThis, double _arg);

		public virtual void SetGlobeRadius(double _arg)
		{
			vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_SetGlobeRadius_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkGeoEdgeStrategy_SetNumberOfSubdivisions_12(HandleRef pThis, int _arg);

		public virtual void SetNumberOfSubdivisions(int _arg)
		{
			vtkGeoEdgeStrategy.vtkGeoEdgeStrategy_SetNumberOfSubdivisions_12(base.GetCppThis(), _arg);
		}
	}
}
