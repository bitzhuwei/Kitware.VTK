using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMergeTables : vtkTableAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMergeTables";

		public new static readonly string MRClassNameKey;

		static vtkMergeTables()
		{
			vtkMergeTables.MRClassNameKey = "class vtkMergeTables";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMergeTables.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeTables"));
		}

		public vtkMergeTables(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeTables_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMergeTables New()
		{
			vtkMergeTables result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeTables.vtkMergeTables_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeTables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMergeTables() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMergeTables.vtkMergeTables_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeTables_GetFirstTablePrefix_01(HandleRef pThis);

		public virtual string GetFirstTablePrefix()
		{
			return Marshal.PtrToStringAnsi(vtkMergeTables.vtkMergeTables_GetFirstTablePrefix_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkMergeTables_GetMergeColumnsByName_02(HandleRef pThis);

		public virtual bool GetMergeColumnsByName()
		{
			return vtkMergeTables.vtkMergeTables_GetMergeColumnsByName_02(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern byte vtkMergeTables_GetPrefixAllButMerged_03(HandleRef pThis);

		public virtual bool GetPrefixAllButMerged()
		{
			return vtkMergeTables.vtkMergeTables_GetPrefixAllButMerged_03(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeTables_GetSecondTablePrefix_04(HandleRef pThis);

		public virtual string GetSecondTablePrefix()
		{
			return Marshal.PtrToStringAnsi(vtkMergeTables.vtkMergeTables_GetSecondTablePrefix_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkMergeTables_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMergeTables.vtkMergeTables_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkMergeTables_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMergeTables.vtkMergeTables_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMergeTables_MergeColumnsByNameOff_07(HandleRef pThis);

		public virtual void MergeColumnsByNameOff()
		{
			vtkMergeTables.vtkMergeTables_MergeColumnsByNameOff_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMergeTables_MergeColumnsByNameOn_08(HandleRef pThis);

		public virtual void MergeColumnsByNameOn()
		{
			vtkMergeTables.vtkMergeTables_MergeColumnsByNameOn_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeTables_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMergeTables NewInstance()
		{
			vtkMergeTables result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeTables.vtkMergeTables_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMergeTables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMergeTables_PrefixAllButMergedOff_11(HandleRef pThis);

		public virtual void PrefixAllButMergedOff()
		{
			vtkMergeTables.vtkMergeTables_PrefixAllButMergedOff_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMergeTables_PrefixAllButMergedOn_12(HandleRef pThis);

		public virtual void PrefixAllButMergedOn()
		{
			vtkMergeTables.vtkMergeTables_PrefixAllButMergedOn_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkMergeTables_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMergeTables SafeDownCast(vtkObjectBase o)
		{
			vtkMergeTables vtkMergeTables = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMergeTables.vtkMergeTables_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMergeTables = (vtkMergeTables)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMergeTables.Register(null);
				}
			}
			return vtkMergeTables;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMergeTables_SetFirstTablePrefix_14(HandleRef pThis, string _arg);

		public virtual void SetFirstTablePrefix(string _arg)
		{
			vtkMergeTables.vtkMergeTables_SetFirstTablePrefix_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMergeTables_SetMergeColumnsByName_15(HandleRef pThis, byte _arg);

		public virtual void SetMergeColumnsByName(bool _arg)
		{
			vtkMergeTables.vtkMergeTables_SetMergeColumnsByName_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMergeTables_SetPrefixAllButMerged_16(HandleRef pThis, byte _arg);

		public virtual void SetPrefixAllButMerged(bool _arg)
		{
			vtkMergeTables.vtkMergeTables_SetPrefixAllButMerged_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkMergeTables_SetSecondTablePrefix_17(HandleRef pThis, string _arg);

		public virtual void SetSecondTablePrefix(string _arg)
		{
			vtkMergeTables.vtkMergeTables_SetSecondTablePrefix_17(base.GetCppThis(), _arg);
		}
	}
}
