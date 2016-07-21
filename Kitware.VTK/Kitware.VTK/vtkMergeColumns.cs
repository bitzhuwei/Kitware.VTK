using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMergeColumns : vtkTableAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergeColumns";

		public new static readonly string MRClassNameKey;

		static vtkMergeColumns()
		{
			vtkMergeColumns.MRClassNameKey = "class vtkMergeColumns";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergeColumns.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeColumns"));
		}

		public vtkMergeColumns(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeColumns_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMergeColumns New()
		{
			vtkMergeColumns result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeColumns.vtkMergeColumns_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeColumns)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMergeColumns() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMergeColumns.vtkMergeColumns_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeColumns_GetMergedColumnName_01(HandleRef pThis);

		public virtual string GetMergedColumnName()
		{
			return Marshal.PtrToStringAnsi(vtkMergeColumns.vtkMergeColumns_GetMergedColumnName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkMergeColumns_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMergeColumns.vtkMergeColumns_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkMergeColumns_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMergeColumns.vtkMergeColumns_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeColumns_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMergeColumns NewInstance()
		{
			vtkMergeColumns result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeColumns.vtkMergeColumns_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeColumns)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeColumns_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMergeColumns SafeDownCast(vtkObjectBase o)
		{
			vtkMergeColumns vtkMergeColumns = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeColumns.vtkMergeColumns_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergeColumns = (vtkMergeColumns)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergeColumns.Register(null);
				}
			}
			return vtkMergeColumns;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMergeColumns_SetMergedColumnName_07(HandleRef pThis, string _arg);

		public virtual void SetMergedColumnName(string _arg)
		{
			vtkMergeColumns.vtkMergeColumns_SetMergedColumnName_07(base.GetCppThis(), _arg);
		}
	}
}
