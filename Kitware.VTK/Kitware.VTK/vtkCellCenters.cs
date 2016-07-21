using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCellCenters : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellCenters";

		public new static readonly string MRClassNameKey;

		static vtkCellCenters()
		{
			vtkCellCenters.MRClassNameKey = "class vtkCellCenters";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellCenters.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellCenters"));
		}

		public vtkCellCenters(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellCenters_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellCenters New()
		{
			vtkCellCenters result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellCenters.vtkCellCenters_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellCenters)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCellCenters() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCellCenters.vtkCellCenters_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCellCenters_GetVertexCells_01(HandleRef pThis);

		public virtual int GetVertexCells()
		{
			return vtkCellCenters.vtkCellCenters_GetVertexCells_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCellCenters_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCellCenters.vtkCellCenters_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkCellCenters_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCellCenters.vtkCellCenters_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellCenters_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCellCenters NewInstance()
		{
			vtkCellCenters result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellCenters.vtkCellCenters_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellCenters)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkCellCenters_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCellCenters SafeDownCast(vtkObjectBase o)
		{
			vtkCellCenters vtkCellCenters = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCellCenters.vtkCellCenters_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellCenters = (vtkCellCenters)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellCenters.Register(null);
				}
			}
			return vtkCellCenters;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellCenters_SetVertexCells_07(HandleRef pThis, int _arg);

		public virtual void SetVertexCells(int _arg)
		{
			vtkCellCenters.vtkCellCenters_SetVertexCells_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellCenters_VertexCellsOff_08(HandleRef pThis);

		public virtual void VertexCellsOff()
		{
			vtkCellCenters.vtkCellCenters_VertexCellsOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkCellCenters_VertexCellsOn_09(HandleRef pThis);

		public virtual void VertexCellsOn()
		{
			vtkCellCenters.vtkCellCenters_VertexCellsOn_09(base.GetCppThis());
		}
	}
}
