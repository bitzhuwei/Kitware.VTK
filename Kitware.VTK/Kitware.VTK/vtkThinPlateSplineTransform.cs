using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkThinPlateSplineTransform : vtkWarpTransform
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkThinPlateSplineTransform";

		public new static readonly string MRClassNameKey;

		static vtkThinPlateSplineTransform()
		{
			vtkThinPlateSplineTransform.MRClassNameKey = "class vtkThinPlateSplineTransform";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkThinPlateSplineTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkThinPlateSplineTransform"));
		}

		public vtkThinPlateSplineTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkThinPlateSplineTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThinPlateSplineTransform New()
		{
			vtkThinPlateSplineTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThinPlateSplineTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkThinPlateSplineTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkThinPlateSplineTransform_GetBasis_01(HandleRef pThis);

		public virtual int GetBasis()
		{
			return vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_GetBasis_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkThinPlateSplineTransform_GetBasisAsString_02(HandleRef pThis);

		public string GetBasisAsString()
		{
			return Marshal.PtrToStringAnsi(vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_GetBasisAsString_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern uint vtkThinPlateSplineTransform_GetMTime_03(HandleRef pThis);

		public override uint GetMTime()
		{
			return vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_GetMTime_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkThinPlateSplineTransform_GetSigma_04(HandleRef pThis);

		public virtual double GetSigma()
		{
			return vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_GetSigma_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkThinPlateSplineTransform_GetSourceLandmarks_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetSourceLandmarks()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_GetSourceLandmarks_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkThinPlateSplineTransform_GetTargetLandmarks_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPoints GetTargetLandmarks()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_GetTargetLandmarks_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkThinPlateSplineTransform_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkThinPlateSplineTransform_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkThinPlateSplineTransform_MakeTransform_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_MakeTransform_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkThinPlateSplineTransform_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkThinPlateSplineTransform NewInstance()
		{
			vtkThinPlateSplineTransform result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkThinPlateSplineTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkThinPlateSplineTransform_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkThinPlateSplineTransform SafeDownCast(vtkObjectBase o)
		{
			vtkThinPlateSplineTransform vtkThinPlateSplineTransform = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkThinPlateSplineTransform = (vtkThinPlateSplineTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkThinPlateSplineTransform.Register(null);
				}
			}
			return vtkThinPlateSplineTransform;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkThinPlateSplineTransform_SetBasis_13(HandleRef pThis, int basis);

		public void SetBasis(int basis)
		{
			vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_SetBasis_13(base.GetCppThis(), basis);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkThinPlateSplineTransform_SetBasisToR_14(HandleRef pThis);

		public void SetBasisToR()
		{
			vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_SetBasisToR_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkThinPlateSplineTransform_SetBasisToR2LogR_15(HandleRef pThis);

		public void SetBasisToR2LogR()
		{
			vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_SetBasisToR2LogR_15(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkThinPlateSplineTransform_SetSigma_16(HandleRef pThis, double _arg);

		public virtual void SetSigma(double _arg)
		{
			vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_SetSigma_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkThinPlateSplineTransform_SetSourceLandmarks_17(HandleRef pThis, HandleRef source);

		public void SetSourceLandmarks(vtkPoints source)
		{
			vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_SetSourceLandmarks_17(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkThinPlateSplineTransform_SetTargetLandmarks_18(HandleRef pThis, HandleRef target);

		public void SetTargetLandmarks(vtkPoints target)
		{
			vtkThinPlateSplineTransform.vtkThinPlateSplineTransform_SetTargetLandmarks_18(base.GetCppThis(), (target == null) ? default(HandleRef) : target.GetCppThis());
		}
	}
}
