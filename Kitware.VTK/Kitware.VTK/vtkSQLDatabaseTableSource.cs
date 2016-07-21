using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkSQLDatabaseTableSource : vtkTableAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkSQLDatabaseTableSource";

		public new static readonly string MRClassNameKey;

		static vtkSQLDatabaseTableSource()
		{
			vtkSQLDatabaseTableSource.MRClassNameKey = "class vtkSQLDatabaseTableSource";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSQLDatabaseTableSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLDatabaseTableSource"));
		}

		public vtkSQLDatabaseTableSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseTableSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSQLDatabaseTableSource New()
		{
			vtkSQLDatabaseTableSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLDatabaseTableSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkSQLDatabaseTableSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseTableSource_GeneratePedigreeIdsOff_01(HandleRef pThis);

		public virtual void GeneratePedigreeIdsOff()
		{
			vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_GeneratePedigreeIdsOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseTableSource_GeneratePedigreeIdsOn_02(HandleRef pThis);

		public virtual void GeneratePedigreeIdsOn()
		{
			vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_GeneratePedigreeIdsOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkSQLDatabaseTableSource_GetGeneratePedigreeIds_03(HandleRef pThis);

		public virtual bool GetGeneratePedigreeIds()
		{
			return vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_GetGeneratePedigreeIds_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseTableSource_GetPedigreeIdArrayName_04(HandleRef pThis);

		public virtual string GetPedigreeIdArrayName()
		{
			return Marshal.PtrToStringAnsi(vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_GetPedigreeIdArrayName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseTableSource_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkSQLDatabaseTableSource_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseTableSource_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkSQLDatabaseTableSource NewInstance()
		{
			vtkSQLDatabaseTableSource result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLDatabaseTableSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkSQLDatabaseTableSource_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkSQLDatabaseTableSource SafeDownCast(vtkObjectBase o)
		{
			vtkSQLDatabaseTableSource vtkSQLDatabaseTableSource = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLDatabaseTableSource = (vtkSQLDatabaseTableSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLDatabaseTableSource.Register(null);
				}
			}
			return vtkSQLDatabaseTableSource;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseTableSource_SetGeneratePedigreeIds_10(HandleRef pThis, byte _arg);

		public virtual void SetGeneratePedigreeIds(bool _arg)
		{
			vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_SetGeneratePedigreeIds_10(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkSQLDatabaseTableSource_SetPedigreeIdArrayName_11(HandleRef pThis, string _arg);

		public virtual void SetPedigreeIdArrayName(string _arg)
		{
			vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_SetPedigreeIdArrayName_11(base.GetCppThis(), _arg);
		}
	}
}
