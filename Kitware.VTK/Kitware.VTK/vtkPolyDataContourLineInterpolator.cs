using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkPolyDataContourLineInterpolator : vtkContourLineInterpolator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataContourLineInterpolator";

		public new static readonly string MRClassNameKey;

		static vtkPolyDataContourLineInterpolator()
		{
			vtkPolyDataContourLineInterpolator.MRClassNameKey = "class vtkPolyDataContourLineInterpolator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataContourLineInterpolator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataContourLineInterpolator"));
		}

		public vtkPolyDataContourLineInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataContourLineInterpolator_GetPolys_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkPolyDataCollection GetPolys()
		{
			vtkPolyDataCollection vtkPolyDataCollection = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataContourLineInterpolator.vtkPolyDataContourLineInterpolator_GetPolys_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataCollection = (vtkPolyDataCollection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataCollection.Register(null);
				}
			}
			return vtkPolyDataCollection;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolyDataContourLineInterpolator_InterpolateLine_02(HandleRef pThis, HandleRef ren, HandleRef rep, int idx1, int idx2);

		public override int InterpolateLine(vtkRenderer ren, vtkContourRepresentation rep, int idx1, int idx2)
		{
			return vtkPolyDataContourLineInterpolator.vtkPolyDataContourLineInterpolator_InterpolateLine_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (rep == null) ? default(HandleRef) : rep.GetCppThis(), idx1, idx2);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolyDataContourLineInterpolator_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPolyDataContourLineInterpolator.vtkPolyDataContourLineInterpolator_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolyDataContourLineInterpolator_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataContourLineInterpolator.vtkPolyDataContourLineInterpolator_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataContourLineInterpolator_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPolyDataContourLineInterpolator NewInstance()
		{
			vtkPolyDataContourLineInterpolator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataContourLineInterpolator.vtkPolyDataContourLineInterpolator_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern IntPtr vtkPolyDataContourLineInterpolator_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPolyDataContourLineInterpolator SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataContourLineInterpolator vtkPolyDataContourLineInterpolator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPolyDataContourLineInterpolator.vtkPolyDataContourLineInterpolator_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataContourLineInterpolator = (vtkPolyDataContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataContourLineInterpolator.Register(null);
				}
			}
			return vtkPolyDataContourLineInterpolator;
		}

		[DllImport("Kitware.VTK.vtkWidgets.Unmanaged.dll")]
		internal static extern int vtkPolyDataContourLineInterpolator_UpdateNode_07(HandleRef pThis, HandleRef arg0, HandleRef arg1, IntPtr arg2, int arg3);

		public override int UpdateNode(vtkRenderer arg0, vtkContourRepresentation arg1, IntPtr arg2, int arg3)
		{
			return vtkPolyDataContourLineInterpolator.vtkPolyDataContourLineInterpolator_UpdateNode_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis(), arg2, arg3);
		}
	}
}
