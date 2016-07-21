using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBlankStructuredGrid : vtkStructuredGridAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBlankStructuredGrid";

		public new static readonly string MRClassNameKey;

		static vtkBlankStructuredGrid()
		{
			vtkBlankStructuredGrid.MRClassNameKey = "class vtkBlankStructuredGrid";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBlankStructuredGrid.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBlankStructuredGrid"));
		}

		public vtkBlankStructuredGrid(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBlankStructuredGrid_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBlankStructuredGrid New()
		{
			vtkBlankStructuredGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBlankStructuredGrid.vtkBlankStructuredGrid_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlankStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBlankStructuredGrid() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBlankStructuredGrid.vtkBlankStructuredGrid_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBlankStructuredGrid_GetArrayId_01(HandleRef pThis);

		public virtual int GetArrayId()
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_GetArrayId_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBlankStructuredGrid_GetArrayName_02(HandleRef pThis);

		public virtual string GetArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkBlankStructuredGrid.vtkBlankStructuredGrid_GetArrayName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBlankStructuredGrid_GetComponent_03(HandleRef pThis);

		public virtual int GetComponent()
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_GetComponent_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBlankStructuredGrid_GetComponentMaxValue_04(HandleRef pThis);

		public virtual int GetComponentMaxValue()
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_GetComponentMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBlankStructuredGrid_GetComponentMinValue_05(HandleRef pThis);

		public virtual int GetComponentMinValue()
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_GetComponentMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkBlankStructuredGrid_GetMaxBlankingValue_06(HandleRef pThis);

		public virtual double GetMaxBlankingValue()
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_GetMaxBlankingValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkBlankStructuredGrid_GetMinBlankingValue_07(HandleRef pThis);

		public virtual double GetMinBlankingValue()
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_GetMinBlankingValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBlankStructuredGrid_IsA_08(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_IsA_08(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkBlankStructuredGrid_IsTypeOf_09(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBlankStructuredGrid.vtkBlankStructuredGrid_IsTypeOf_09(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBlankStructuredGrid_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBlankStructuredGrid NewInstance()
		{
			vtkBlankStructuredGrid result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBlankStructuredGrid.vtkBlankStructuredGrid_NewInstance_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlankStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkBlankStructuredGrid_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBlankStructuredGrid SafeDownCast(vtkObjectBase o)
		{
			vtkBlankStructuredGrid vtkBlankStructuredGrid = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBlankStructuredGrid.vtkBlankStructuredGrid_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBlankStructuredGrid = (vtkBlankStructuredGrid)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBlankStructuredGrid.Register(null);
				}
			}
			return vtkBlankStructuredGrid;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBlankStructuredGrid_SetArrayId_13(HandleRef pThis, int _arg);

		public virtual void SetArrayId(int _arg)
		{
			vtkBlankStructuredGrid.vtkBlankStructuredGrid_SetArrayId_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBlankStructuredGrid_SetArrayName_14(HandleRef pThis, string _arg);

		public virtual void SetArrayName(string _arg)
		{
			vtkBlankStructuredGrid.vtkBlankStructuredGrid_SetArrayName_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBlankStructuredGrid_SetComponent_15(HandleRef pThis, int _arg);

		public virtual void SetComponent(int _arg)
		{
			vtkBlankStructuredGrid.vtkBlankStructuredGrid_SetComponent_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBlankStructuredGrid_SetMaxBlankingValue_16(HandleRef pThis, double _arg);

		public virtual void SetMaxBlankingValue(double _arg)
		{
			vtkBlankStructuredGrid.vtkBlankStructuredGrid_SetMaxBlankingValue_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkBlankStructuredGrid_SetMinBlankingValue_17(HandleRef pThis, double _arg);

		public virtual void SetMinBlankingValue(double _arg)
		{
			vtkBlankStructuredGrid.vtkBlankStructuredGrid_SetMinBlankingValue_17(base.GetCppThis(), _arg);
		}
	}
}
