using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolyDataNormals : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataNormals";

		public new static readonly string MRClassNameKey;

		static vtkPolyDataNormals()
		{
			vtkPolyDataNormals.MRClassNameKey = "class vtkPolyDataNormals";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataNormals.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataNormals"));
		}

		public vtkPolyDataNormals(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataNormals_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataNormals New()
		{
			vtkPolyDataNormals result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataNormals.vtkPolyDataNormals_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataNormals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolyDataNormals() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolyDataNormals.vtkPolyDataNormals_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_AutoOrientNormalsOff_01(HandleRef pThis);

		public virtual void AutoOrientNormalsOff()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_AutoOrientNormalsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_AutoOrientNormalsOn_02(HandleRef pThis);

		public virtual void AutoOrientNormalsOn()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_AutoOrientNormalsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_ComputeCellNormalsOff_03(HandleRef pThis);

		public virtual void ComputeCellNormalsOff()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_ComputeCellNormalsOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_ComputeCellNormalsOn_04(HandleRef pThis);

		public virtual void ComputeCellNormalsOn()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_ComputeCellNormalsOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_ComputePointNormalsOff_05(HandleRef pThis);

		public virtual void ComputePointNormalsOff()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_ComputePointNormalsOff_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_ComputePointNormalsOn_06(HandleRef pThis);

		public virtual void ComputePointNormalsOn()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_ComputePointNormalsOn_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_ConsistencyOff_07(HandleRef pThis);

		public virtual void ConsistencyOff()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_ConsistencyOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_ConsistencyOn_08(HandleRef pThis);

		public virtual void ConsistencyOn()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_ConsistencyOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_FlipNormalsOff_09(HandleRef pThis);

		public virtual void FlipNormalsOff()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_FlipNormalsOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_FlipNormalsOn_10(HandleRef pThis);

		public virtual void FlipNormalsOn()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_FlipNormalsOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataNormals_GetAutoOrientNormals_11(HandleRef pThis);

		public virtual int GetAutoOrientNormals()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetAutoOrientNormals_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataNormals_GetComputeCellNormals_12(HandleRef pThis);

		public virtual int GetComputeCellNormals()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetComputeCellNormals_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataNormals_GetComputePointNormals_13(HandleRef pThis);

		public virtual int GetComputePointNormals()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetComputePointNormals_13(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataNormals_GetConsistency_14(HandleRef pThis);

		public virtual int GetConsistency()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetConsistency_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkPolyDataNormals_GetFeatureAngle_15(HandleRef pThis);

		public virtual double GetFeatureAngle()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetFeatureAngle_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkPolyDataNormals_GetFeatureAngleMaxValue_16(HandleRef pThis);

		public virtual double GetFeatureAngleMaxValue()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetFeatureAngleMaxValue_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkPolyDataNormals_GetFeatureAngleMinValue_17(HandleRef pThis);

		public virtual double GetFeatureAngleMinValue()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetFeatureAngleMinValue_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataNormals_GetFlipNormals_18(HandleRef pThis);

		public virtual int GetFlipNormals()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetFlipNormals_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataNormals_GetNonManifoldTraversal_19(HandleRef pThis);

		public virtual int GetNonManifoldTraversal()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetNonManifoldTraversal_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataNormals_GetSplitting_20(HandleRef pThis);

		public virtual int GetSplitting()
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_GetSplitting_20(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataNormals_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkPolyDataNormals_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataNormals.vtkPolyDataNormals_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataNormals_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyDataNormals NewInstance()
		{
			vtkPolyDataNormals result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataNormals.vtkPolyDataNormals_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataNormals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_NonManifoldTraversalOff_25(HandleRef pThis);

		public virtual void NonManifoldTraversalOff()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_NonManifoldTraversalOff_25(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_NonManifoldTraversalOn_26(HandleRef pThis);

		public virtual void NonManifoldTraversalOn()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_NonManifoldTraversalOn_26(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataNormals_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataNormals SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataNormals vtkPolyDataNormals = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataNormals.vtkPolyDataNormals_SafeDownCast_27((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataNormals = (vtkPolyDataNormals)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataNormals.Register(null);
				}
			}
			return vtkPolyDataNormals;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_SetAutoOrientNormals_28(HandleRef pThis, int _arg);

		public virtual void SetAutoOrientNormals(int _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetAutoOrientNormals_28(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_SetComputeCellNormals_29(HandleRef pThis, int _arg);

		public virtual void SetComputeCellNormals(int _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetComputeCellNormals_29(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_SetComputePointNormals_30(HandleRef pThis, int _arg);

		public virtual void SetComputePointNormals(int _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetComputePointNormals_30(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_SetConsistency_31(HandleRef pThis, int _arg);

		public virtual void SetConsistency(int _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetConsistency_31(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_SetFeatureAngle_32(HandleRef pThis, double _arg);

		public virtual void SetFeatureAngle(double _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetFeatureAngle_32(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_SetFlipNormals_33(HandleRef pThis, int _arg);

		public virtual void SetFlipNormals(int _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetFlipNormals_33(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_SetNonManifoldTraversal_34(HandleRef pThis, int _arg);

		public virtual void SetNonManifoldTraversal(int _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetNonManifoldTraversal_34(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_SetSplitting_35(HandleRef pThis, int _arg);

		public virtual void SetSplitting(int _arg)
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SetSplitting_35(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_SplittingOff_36(HandleRef pThis);

		public virtual void SplittingOff()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SplittingOff_36(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkPolyDataNormals_SplittingOn_37(HandleRef pThis);

		public virtual void SplittingOn()
		{
			vtkPolyDataNormals.vtkPolyDataNormals_SplittingOn_37(base.GetCppThis());
		}
	}
}
