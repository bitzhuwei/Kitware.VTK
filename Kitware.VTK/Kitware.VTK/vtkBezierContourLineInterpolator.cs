using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBezierContourLineInterpolator : vtkContourLineInterpolator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBezierContourLineInterpolator";

		public new static readonly string MRClassNameKey;

		static vtkBezierContourLineInterpolator()
		{
			vtkBezierContourLineInterpolator.MRClassNameKey = "class vtkBezierContourLineInterpolator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBezierContourLineInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBezierContourLineInterpolator"));
		}

		public vtkBezierContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBezierContourLineInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBezierContourLineInterpolator New()
		{
			vtkBezierContourLineInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBezierContourLineInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkBezierContourLineInterpolator_GetMaximumCurveError_01(HandleRef pThis);

		public virtual double GetMaximumCurveError()
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_GetMaximumCurveError_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkBezierContourLineInterpolator_GetMaximumCurveErrorMaxValue_02(HandleRef pThis);

		public virtual double GetMaximumCurveErrorMaxValue()
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_GetMaximumCurveErrorMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkBezierContourLineInterpolator_GetMaximumCurveErrorMinValue_03(HandleRef pThis);

		public virtual double GetMaximumCurveErrorMinValue()
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_GetMaximumCurveErrorMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBezierContourLineInterpolator_GetMaximumCurveLineSegments_04(HandleRef pThis);

		public virtual int GetMaximumCurveLineSegments()
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_GetMaximumCurveLineSegments_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBezierContourLineInterpolator_GetMaximumCurveLineSegmentsMaxValue_05(HandleRef pThis);

		public virtual int GetMaximumCurveLineSegmentsMaxValue()
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_GetMaximumCurveLineSegmentsMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBezierContourLineInterpolator_GetMaximumCurveLineSegmentsMinValue_06(HandleRef pThis);

		public virtual int GetMaximumCurveLineSegmentsMinValue()
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_GetMaximumCurveLineSegmentsMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBezierContourLineInterpolator_GetSpan_07(HandleRef pThis, int nodeIndex, HandleRef nodeIndices, HandleRef rep);

		public override void GetSpan(int nodeIndex, vtkIntArray nodeIndices, vtkContourRepresentation rep)
		{
			vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_GetSpan_07(base.GetCppThis(), nodeIndex, (nodeIndices == null) ? default(HandleRef) : nodeIndices.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBezierContourLineInterpolator_InterpolateLine_08(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

		public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_InterpolateLine_08(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), idx1, idx2);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBezierContourLineInterpolator_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkBezierContourLineInterpolator_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBezierContourLineInterpolator_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBezierContourLineInterpolator NewInstance()
		{
			vtkBezierContourLineInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBezierContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkBezierContourLineInterpolator_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBezierContourLineInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkBezierContourLineInterpolator vtkBezierContourLineInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBezierContourLineInterpolator = (vtkBezierContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBezierContourLineInterpolator.Register(null);
				}
			}
			return vtkBezierContourLineInterpolator;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBezierContourLineInterpolator_SetMaximumCurveError_14(HandleRef pThis, double _arg);

		public virtual void SetMaximumCurveError(double _arg)
		{
			vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_SetMaximumCurveError_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkBezierContourLineInterpolator_SetMaximumCurveLineSegments_15(HandleRef pThis, int _arg);

		public virtual void SetMaximumCurveLineSegments(int _arg)
		{
			vtkBezierContourLineInterpolator.vtkBezierContourLineInterpolator_SetMaximumCurveLineSegments_15(base.GetCppThis(), _arg);
		}
	}
}
