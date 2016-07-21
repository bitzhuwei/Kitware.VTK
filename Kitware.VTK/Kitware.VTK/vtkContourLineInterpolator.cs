using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkContourLineInterpolator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkContourLineInterpolator";

		public new static readonly string MRClassNameKey;

		static vtkContourLineInterpolator()
		{
			vtkContourLineInterpolator.MRClassNameKey = "class vtkContourLineInterpolator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContourLineInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourLineInterpolator"));
		}

		public vtkContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern void vtkContourLineInterpolator_GetSpan_01(HandleRef pThis, int nodeIndex, HandleRef nodeIndices, HandleRef rep);

		public virtual void GetSpan(int nodeIndex, vtkIntArray nodeIndices, vtkContourRepresentation rep)
		{
			vtkContourLineInterpolator.vtkContourLineInterpolator_GetSpan_01(base.GetCppThis(), nodeIndex, (nodeIndices == null) ? default(HandleRef) : nodeIndices.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourLineInterpolator_InterpolateLine_02(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

		public virtual int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
		{
			return vtkContourLineInterpolator.vtkContourLineInterpolator_InterpolateLine_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), idx1, idx2);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourLineInterpolator_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkContourLineInterpolator.vtkContourLineInterpolator_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourLineInterpolator_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkContourLineInterpolator.vtkContourLineInterpolator_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkContourLineInterpolator_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkContourLineInterpolator NewInstance()
		{
			vtkContourLineInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourLineInterpolator.vtkContourLineInterpolator_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkContourLineInterpolator_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkContourLineInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkContourLineInterpolator vtkContourLineInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkContourLineInterpolator.vtkContourLineInterpolator_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourLineInterpolator = (vtkContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourLineInterpolator.Register(null);
				}
			}
			return vtkContourLineInterpolator;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkContourLineInterpolator_UpdateNode_07(HandleRef pThis, HandleRef arg0, HandleRef arg1, IntPtr arg2, int arg3);

		public virtual int UpdateNode(vtkRenderer arg0, vtkContourRepresentation arg1, IntPtr arg2, int arg3)
		{
			return vtkContourLineInterpolator.vtkContourLineInterpolator_UpdateNode_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3);
		}
	}
}
