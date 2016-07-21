using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractDataSets : vtkHierarchicalBoxDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractDataSets";

		public new static readonly string MRClassNameKey;

		static vtkExtractDataSets()
		{
			vtkExtractDataSets.MRClassNameKey = "class vtkExtractDataSets";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractDataSets.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractDataSets"));
		}

		public vtkExtractDataSets(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractDataSets_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractDataSets New()
		{
			vtkExtractDataSets result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractDataSets.vtkExtractDataSets_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractDataSets)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractDataSets() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractDataSets.vtkExtractDataSets_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractDataSets_AddDataSet_01(HandleRef pThis, uint level, uint idx);

		public void AddDataSet(uint level, uint idx)
		{
			vtkExtractDataSets.vtkExtractDataSets_AddDataSet_01(base.GetCppThis(), level, idx);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractDataSets_ClearDataSetList_02(HandleRef pThis);

		public void ClearDataSetList()
		{
			vtkExtractDataSets.vtkExtractDataSets_ClearDataSetList_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractDataSets_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractDataSets.vtkExtractDataSets_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractDataSets_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractDataSets.vtkExtractDataSets_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractDataSets_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractDataSets NewInstance()
		{
			vtkExtractDataSets result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractDataSets.vtkExtractDataSets_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractDataSets)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractDataSets_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractDataSets SafeDownCast(vtkObjectBase o)
		{
			vtkExtractDataSets vtkExtractDataSets = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractDataSets.vtkExtractDataSets_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractDataSets = (vtkExtractDataSets)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractDataSets.Register(null);
				}
			}
			return vtkExtractDataSets;
		}
	}
}
