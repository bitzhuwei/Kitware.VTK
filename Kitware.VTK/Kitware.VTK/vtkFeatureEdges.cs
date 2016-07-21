using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkFeatureEdges : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkFeatureEdges";

		public new static readonly string MRClassNameKey;

		static vtkFeatureEdges()
		{
			vtkFeatureEdges.MRClassNameKey = "class vtkFeatureEdges";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFeatureEdges.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFeatureEdges"));
		}

		public vtkFeatureEdges(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFeatureEdges_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFeatureEdges New()
		{
			vtkFeatureEdges result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFeatureEdges.vtkFeatureEdges_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFeatureEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkFeatureEdges() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkFeatureEdges.vtkFeatureEdges_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_BoundaryEdgesOff_01(HandleRef pThis);

		public virtual void BoundaryEdgesOff()
		{
			vtkFeatureEdges.vtkFeatureEdges_BoundaryEdgesOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_BoundaryEdgesOn_02(HandleRef pThis);

		public virtual void BoundaryEdgesOn()
		{
			vtkFeatureEdges.vtkFeatureEdges_BoundaryEdgesOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_ColoringOff_03(HandleRef pThis);

		public virtual void ColoringOff()
		{
			vtkFeatureEdges.vtkFeatureEdges_ColoringOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_ColoringOn_04(HandleRef pThis);

		public virtual void ColoringOn()
		{
			vtkFeatureEdges.vtkFeatureEdges_ColoringOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_CreateDefaultLocator_05(HandleRef pThis);

		public void CreateDefaultLocator()
		{
			vtkFeatureEdges.vtkFeatureEdges_CreateDefaultLocator_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_FeatureEdgesOff_06(HandleRef pThis);

		public virtual void FeatureEdgesOff()
		{
			vtkFeatureEdges.vtkFeatureEdges_FeatureEdgesOff_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_FeatureEdgesOn_07(HandleRef pThis);

		public virtual void FeatureEdgesOn()
		{
			vtkFeatureEdges.vtkFeatureEdges_FeatureEdgesOn_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFeatureEdges_GetBoundaryEdges_08(HandleRef pThis);

		public virtual int GetBoundaryEdges()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetBoundaryEdges_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFeatureEdges_GetColoring_09(HandleRef pThis);

		public virtual int GetColoring()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetColoring_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkFeatureEdges_GetFeatureAngle_10(HandleRef pThis);

		public virtual double GetFeatureAngle()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetFeatureAngle_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkFeatureEdges_GetFeatureAngleMaxValue_11(HandleRef pThis);

		public virtual double GetFeatureAngleMaxValue()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetFeatureAngleMaxValue_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkFeatureEdges_GetFeatureAngleMinValue_12(HandleRef pThis);

		public virtual double GetFeatureAngleMinValue()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetFeatureAngleMinValue_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFeatureEdges_GetFeatureEdges_13(HandleRef pThis);

		public virtual int GetFeatureEdges()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetFeatureEdges_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFeatureEdges_GetLocator_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFeatureEdges.vtkFeatureEdges_GetLocator_14(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern uint vtkFeatureEdges_GetMTime_15(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetMTime_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFeatureEdges_GetManifoldEdges_16(HandleRef pThis);

		public virtual int GetManifoldEdges()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetManifoldEdges_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFeatureEdges_GetNonManifoldEdges_17(HandleRef pThis);

		public virtual int GetNonManifoldEdges()
		{
			return vtkFeatureEdges.vtkFeatureEdges_GetNonManifoldEdges_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFeatureEdges_IsA_18(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkFeatureEdges.vtkFeatureEdges_IsA_18(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkFeatureEdges_IsTypeOf_19(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkFeatureEdges.vtkFeatureEdges_IsTypeOf_19(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_ManifoldEdgesOff_20(HandleRef pThis);

		public virtual void ManifoldEdgesOff()
		{
			vtkFeatureEdges.vtkFeatureEdges_ManifoldEdgesOff_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_ManifoldEdgesOn_21(HandleRef pThis);

		public virtual void ManifoldEdgesOn()
		{
			vtkFeatureEdges.vtkFeatureEdges_ManifoldEdgesOn_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFeatureEdges_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkFeatureEdges NewInstance()
		{
			vtkFeatureEdges result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFeatureEdges.vtkFeatureEdges_NewInstance_23(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFeatureEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_NonManifoldEdgesOff_24(HandleRef pThis);

		public virtual void NonManifoldEdgesOff()
		{
			vtkFeatureEdges.vtkFeatureEdges_NonManifoldEdgesOff_24(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_NonManifoldEdgesOn_25(HandleRef pThis);

		public virtual void NonManifoldEdgesOn()
		{
			vtkFeatureEdges.vtkFeatureEdges_NonManifoldEdgesOn_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkFeatureEdges_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkFeatureEdges SafeDownCast(vtkObjectBase o)
		{
			vtkFeatureEdges vtkFeatureEdges = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkFeatureEdges.vtkFeatureEdges_SafeDownCast_26((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFeatureEdges = (vtkFeatureEdges)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFeatureEdges.Register(null);
				}
			}
			return vtkFeatureEdges;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_SetBoundaryEdges_27(HandleRef pThis, int _arg);

		public virtual void SetBoundaryEdges(int _arg)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetBoundaryEdges_27(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_SetColoring_28(HandleRef pThis, int _arg);

		public virtual void SetColoring(int _arg)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetColoring_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_SetFeatureAngle_29(HandleRef pThis, double _arg);

		public virtual void SetFeatureAngle(double _arg)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetFeatureAngle_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_SetFeatureEdges_30(HandleRef pThis, int _arg);

		public virtual void SetFeatureEdges(int _arg)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetFeatureEdges_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_SetLocator_31(HandleRef pThis, HandleRef locator);

		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetLocator_31(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_SetManifoldEdges_32(HandleRef pThis, int _arg);

		public virtual void SetManifoldEdges(int _arg)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetManifoldEdges_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkFeatureEdges_SetNonManifoldEdges_33(HandleRef pThis, int _arg);

		public virtual void SetNonManifoldEdges(int _arg)
		{
			vtkFeatureEdges.vtkFeatureEdges_SetNonManifoldEdges_33(base.GetCppThis(), _arg);
		}
	}
}
