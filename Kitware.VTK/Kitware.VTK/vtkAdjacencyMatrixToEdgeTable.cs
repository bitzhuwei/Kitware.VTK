using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkAdjacencyMatrixToEdgeTable : vtkTableAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkAdjacencyMatrixToEdgeTable";

		public new static readonly string MRClassNameKey;

		static vtkAdjacencyMatrixToEdgeTable()
		{
			vtkAdjacencyMatrixToEdgeTable.MRClassNameKey = "class vtkAdjacencyMatrixToEdgeTable";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAdjacencyMatrixToEdgeTable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAdjacencyMatrixToEdgeTable"));
		}

		public vtkAdjacencyMatrixToEdgeTable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAdjacencyMatrixToEdgeTable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAdjacencyMatrixToEdgeTable New()
		{
			vtkAdjacencyMatrixToEdgeTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAdjacencyMatrixToEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkAdjacencyMatrixToEdgeTable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkAdjacencyMatrixToEdgeTable_GetMinimumCount_01(HandleRef pThis);

		public virtual long GetMinimumCount()
		{
			return vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_GetMinimumCount_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern double vtkAdjacencyMatrixToEdgeTable_GetMinimumThreshold_02(HandleRef pThis);

		public virtual double GetMinimumThreshold()
		{
			return vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_GetMinimumThreshold_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern long vtkAdjacencyMatrixToEdgeTable_GetSourceDimension_03(HandleRef pThis);

		public virtual long GetSourceDimension()
		{
			return vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_GetSourceDimension_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAdjacencyMatrixToEdgeTable_GetValueArrayName_04(HandleRef pThis);

		public virtual string GetValueArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_GetValueArrayName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAdjacencyMatrixToEdgeTable_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkAdjacencyMatrixToEdgeTable_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAdjacencyMatrixToEdgeTable_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkAdjacencyMatrixToEdgeTable NewInstance()
		{
			vtkAdjacencyMatrixToEdgeTable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAdjacencyMatrixToEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkAdjacencyMatrixToEdgeTable_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkAdjacencyMatrixToEdgeTable SafeDownCast(vtkObjectBase o)
		{
			vtkAdjacencyMatrixToEdgeTable vtkAdjacencyMatrixToEdgeTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAdjacencyMatrixToEdgeTable = (vtkAdjacencyMatrixToEdgeTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAdjacencyMatrixToEdgeTable.Register(null);
				}
			}
			return vtkAdjacencyMatrixToEdgeTable;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAdjacencyMatrixToEdgeTable_SetMinimumCount_10(HandleRef pThis, long _arg);

		public virtual void SetMinimumCount(long _arg)
		{
			vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_SetMinimumCount_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAdjacencyMatrixToEdgeTable_SetMinimumThreshold_11(HandleRef pThis, double _arg);

		public virtual void SetMinimumThreshold(double _arg)
		{
			vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_SetMinimumThreshold_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAdjacencyMatrixToEdgeTable_SetSourceDimension_12(HandleRef pThis, long _arg);

		public virtual void SetSourceDimension(long _arg)
		{
			vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_SetSourceDimension_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkAdjacencyMatrixToEdgeTable_SetValueArrayName_13(HandleRef pThis, string _arg);

		public virtual void SetValueArrayName(string _arg)
		{
			vtkAdjacencyMatrixToEdgeTable.vtkAdjacencyMatrixToEdgeTable_SetValueArrayName_13(base.GetCppThis(), _arg);
		}
	}
}
