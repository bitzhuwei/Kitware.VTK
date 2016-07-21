using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkReverseSense : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkReverseSense";

		public new static readonly string MRClassNameKey;

		static vtkReverseSense()
		{
			vtkReverseSense.MRClassNameKey = "class vtkReverseSense";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkReverseSense.MRClassNameKey, Type.GetType("Kitware.VTK.vtkReverseSense"));
		}

		public vtkReverseSense(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReverseSense_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkReverseSense New()
		{
			vtkReverseSense result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReverseSense.vtkReverseSense_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReverseSense)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkReverseSense() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkReverseSense.vtkReverseSense_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReverseSense_GetReverseCells_01(HandleRef pThis);

		public virtual int GetReverseCells()
		{
			return vtkReverseSense.vtkReverseSense_GetReverseCells_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReverseSense_GetReverseNormals_02(HandleRef pThis);

		public virtual int GetReverseNormals()
		{
			return vtkReverseSense.vtkReverseSense_GetReverseNormals_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReverseSense_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkReverseSense.vtkReverseSense_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkReverseSense_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkReverseSense.vtkReverseSense_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReverseSense_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkReverseSense NewInstance()
		{
			vtkReverseSense result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReverseSense.vtkReverseSense_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkReverseSense)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReverseSense_ReverseCellsOff_07(HandleRef pThis);

		public virtual void ReverseCellsOff()
		{
			vtkReverseSense.vtkReverseSense_ReverseCellsOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReverseSense_ReverseCellsOn_08(HandleRef pThis);

		public virtual void ReverseCellsOn()
		{
			vtkReverseSense.vtkReverseSense_ReverseCellsOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReverseSense_ReverseNormalsOff_09(HandleRef pThis);

		public virtual void ReverseNormalsOff()
		{
			vtkReverseSense.vtkReverseSense_ReverseNormalsOff_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReverseSense_ReverseNormalsOn_10(HandleRef pThis);

		public virtual void ReverseNormalsOn()
		{
			vtkReverseSense.vtkReverseSense_ReverseNormalsOn_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkReverseSense_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkReverseSense SafeDownCast(vtkObjectBase o)
		{
			vtkReverseSense vtkReverseSense = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkReverseSense.vtkReverseSense_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkReverseSense = (vtkReverseSense)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkReverseSense.Register(null);
				}
			}
			return vtkReverseSense;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReverseSense_SetReverseCells_12(HandleRef pThis, int _arg);

		public virtual void SetReverseCells(int _arg)
		{
			vtkReverseSense.vtkReverseSense_SetReverseCells_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkReverseSense_SetReverseNormals_13(HandleRef pThis, int _arg);

		public virtual void SetReverseNormals(int _arg)
		{
			vtkReverseSense.vtkReverseSense_SetReverseNormals_13(base.GetCppThis(), _arg);
		}
	}
}
