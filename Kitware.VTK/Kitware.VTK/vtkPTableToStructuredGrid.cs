using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPTableToStructuredGrid : vtkTableToStructuredGrid
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPTableToStructuredGrid";

		public new static readonly string MRClassNameKey;

		static vtkPTableToStructuredGrid()
		{
			vtkPTableToStructuredGrid.MRClassNameKey = "class vtkPTableToStructuredGrid";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPTableToStructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPTableToStructuredGrid"));
		}

		public vtkPTableToStructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPTableToStructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPTableToStructuredGrid New()
		{
			vtkPTableToStructuredGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPTableToStructuredGrid.vtkPTableToStructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPTableToStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPTableToStructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPTableToStructuredGrid.vtkPTableToStructuredGrid_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPTableToStructuredGrid_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPTableToStructuredGrid.vtkPTableToStructuredGrid_GetController_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPTableToStructuredGrid_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPTableToStructuredGrid.vtkPTableToStructuredGrid_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPTableToStructuredGrid_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPTableToStructuredGrid.vtkPTableToStructuredGrid_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPTableToStructuredGrid_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPTableToStructuredGrid NewInstance()
		{
			vtkPTableToStructuredGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPTableToStructuredGrid.vtkPTableToStructuredGrid_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPTableToStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPTableToStructuredGrid_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPTableToStructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkPTableToStructuredGrid vtkPTableToStructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPTableToStructuredGrid.vtkPTableToStructuredGrid_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPTableToStructuredGrid = (vtkPTableToStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPTableToStructuredGrid.Register(null);
				}
			}
			return vtkPTableToStructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPTableToStructuredGrid_SetController_07(HandleRef pThis, HandleRef arg0);

		public void SetController(vtkMultiProcessController arg0)
		{
			vtkPTableToStructuredGrid.vtkPTableToStructuredGrid_SetController_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
