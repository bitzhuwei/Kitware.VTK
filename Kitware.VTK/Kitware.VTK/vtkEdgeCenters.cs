using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkEdgeCenters : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEdgeCenters";

		public new static readonly string MRClassNameKey;

		static vtkEdgeCenters()
		{
			vtkEdgeCenters.MRClassNameKey = "class vtkEdgeCenters";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEdgeCenters.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEdgeCenters"));
		}

		public vtkEdgeCenters(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeCenters_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEdgeCenters New()
		{
			vtkEdgeCenters result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgeCenters.vtkEdgeCenters_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeCenters)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkEdgeCenters() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkEdgeCenters.vtkEdgeCenters_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkEdgeCenters_GetVertexCells_01(HandleRef pThis);

		public virtual int GetVertexCells()
		{
			return vtkEdgeCenters.vtkEdgeCenters_GetVertexCells_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkEdgeCenters_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEdgeCenters.vtkEdgeCenters_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkEdgeCenters_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEdgeCenters.vtkEdgeCenters_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeCenters_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEdgeCenters NewInstance()
		{
			vtkEdgeCenters result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgeCenters.vtkEdgeCenters_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgeCenters)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkEdgeCenters_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEdgeCenters SafeDownCast(vtkObjectBase o)
		{
			vtkEdgeCenters vtkEdgeCenters = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEdgeCenters.vtkEdgeCenters_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgeCenters = (vtkEdgeCenters)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgeCenters.Register(null);
				}
			}
			return vtkEdgeCenters;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkEdgeCenters_SetVertexCells_07(HandleRef pThis, int _arg);

		public virtual void SetVertexCells(int _arg)
		{
			vtkEdgeCenters.vtkEdgeCenters_SetVertexCells_07(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkEdgeCenters_VertexCellsOff_08(HandleRef pThis);

		public virtual void VertexCellsOff()
		{
			vtkEdgeCenters.vtkEdgeCenters_VertexCellsOff_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkEdgeCenters_VertexCellsOn_09(HandleRef pThis);

		public virtual void VertexCellsOn()
		{
			vtkEdgeCenters.vtkEdgeCenters_VertexCellsOn_09(base.GetCppThis());
		}
	}
}
