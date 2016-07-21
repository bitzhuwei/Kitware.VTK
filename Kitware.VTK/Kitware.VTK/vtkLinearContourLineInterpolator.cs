using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkLinearContourLineInterpolator : vtkContourLineInterpolator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkLinearContourLineInterpolator";

		public new static readonly string MRClassNameKey;

		static vtkLinearContourLineInterpolator()
		{
			vtkLinearContourLineInterpolator.MRClassNameKey = "class vtkLinearContourLineInterpolator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLinearContourLineInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearContourLineInterpolator"));
		}

		public vtkLinearContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearContourLineInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLinearContourLineInterpolator New()
		{
			vtkLinearContourLineInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLinearContourLineInterpolator.vtkLinearContourLineInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkLinearContourLineInterpolator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkLinearContourLineInterpolator.vtkLinearContourLineInterpolator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLinearContourLineInterpolator_InterpolateLine_01(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

		public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
		{
			return vtkLinearContourLineInterpolator.vtkLinearContourLineInterpolator_InterpolateLine_01(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), idx1, idx2);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLinearContourLineInterpolator_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkLinearContourLineInterpolator.vtkLinearContourLineInterpolator_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkLinearContourLineInterpolator_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkLinearContourLineInterpolator.vtkLinearContourLineInterpolator_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearContourLineInterpolator_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkLinearContourLineInterpolator NewInstance()
		{
			vtkLinearContourLineInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLinearContourLineInterpolator.vtkLinearContourLineInterpolator_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkLinearContourLineInterpolator_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkLinearContourLineInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkLinearContourLineInterpolator vtkLinearContourLineInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkLinearContourLineInterpolator.vtkLinearContourLineInterpolator_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinearContourLineInterpolator = (vtkLinearContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinearContourLineInterpolator.Register(null);
				}
			}
			return vtkLinearContourLineInterpolator;
		}
	}
}
