using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPolygonalSurfaceContourLineInterpolator : vtkPolyDataContourLineInterpolator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolygonalSurfaceContourLineInterpolator";

		public new static readonly string MRClassNameKey;

		static vtkPolygonalSurfaceContourLineInterpolator()
		{
			vtkPolygonalSurfaceContourLineInterpolator.MRClassNameKey = "class vtkPolygonalSurfaceContourLineInterpolator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolygonalSurfaceContourLineInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolygonalSurfaceContourLineInterpolator"));
		}

		public vtkPolygonalSurfaceContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygonalSurfaceContourLineInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolygonalSurfaceContourLineInterpolator New()
		{
			vtkPolygonalSurfaceContourLineInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygonalSurfaceContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPolygonalSurfaceContourLineInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern double vtkPolygonalSurfaceContourLineInterpolator_GetDistanceOffset_01(HandleRef pThis);

		public virtual double GetDistanceOffset()
		{
			return vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_GetDistanceOffset_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolygonalSurfaceContourLineInterpolator_InterpolateLine_02(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

		public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
		{
			return vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_InterpolateLine_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), idx1, idx2);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolygonalSurfaceContourLineInterpolator_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolygonalSurfaceContourLineInterpolator_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygonalSurfaceContourLineInterpolator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolygonalSurfaceContourLineInterpolator NewInstance()
		{
			vtkPolygonalSurfaceContourLineInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolygonalSurfaceContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolygonalSurfaceContourLineInterpolator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolygonalSurfaceContourLineInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkPolygonalSurfaceContourLineInterpolator vtkPolygonalSurfaceContourLineInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolygonalSurfaceContourLineInterpolator = (vtkPolygonalSurfaceContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolygonalSurfaceContourLineInterpolator.Register(null);
				}
			}
			return vtkPolygonalSurfaceContourLineInterpolator;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkPolygonalSurfaceContourLineInterpolator_SetDistanceOffset_08(HandleRef pThis, double _arg);

		public virtual void SetDistanceOffset(double _arg)
		{
			vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_SetDistanceOffset_08(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolygonalSurfaceContourLineInterpolator_UpdateNode_09(HandleRef pThis, HandleRef arg0, HandleRef arg1, IntPtr arg2, int arg3);

		public override int UpdateNode(vtkRenderer arg0, vtkContourRepresentation arg1, IntPtr arg2, int arg3)
		{
			return vtkPolygonalSurfaceContourLineInterpolator.vtkPolygonalSurfaceContourLineInterpolator_UpdateNode_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3);
		}
	}
}
