using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHierarchicalDataExtractDataSets : vtkExtractDataSets
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalDataExtractDataSets";

		public new static readonly string MRClassNameKey;

		static vtkHierarchicalDataExtractDataSets()
		{
			vtkHierarchicalDataExtractDataSets.MRClassNameKey = "class vtkHierarchicalDataExtractDataSets";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalDataExtractDataSets.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalDataExtractDataSets"));
		}

		public vtkHierarchicalDataExtractDataSets(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalDataExtractDataSets_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalDataExtractDataSets New()
		{
			vtkHierarchicalDataExtractDataSets result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalDataExtractDataSets.vtkHierarchicalDataExtractDataSets_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalDataExtractDataSets)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHierarchicalDataExtractDataSets() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHierarchicalDataExtractDataSets.vtkHierarchicalDataExtractDataSets_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHierarchicalDataExtractDataSets_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHierarchicalDataExtractDataSets.vtkHierarchicalDataExtractDataSets_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHierarchicalDataExtractDataSets_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalDataExtractDataSets.vtkHierarchicalDataExtractDataSets_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalDataExtractDataSets_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHierarchicalDataExtractDataSets NewInstance()
		{
			vtkHierarchicalDataExtractDataSets result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalDataExtractDataSets.vtkHierarchicalDataExtractDataSets_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalDataExtractDataSets)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHierarchicalDataExtractDataSets_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHierarchicalDataExtractDataSets SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalDataExtractDataSets vtkHierarchicalDataExtractDataSets = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHierarchicalDataExtractDataSets.vtkHierarchicalDataExtractDataSets_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalDataExtractDataSets = (vtkHierarchicalDataExtractDataSets)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalDataExtractDataSets.Register(null);
				}
			}
			return vtkHierarchicalDataExtractDataSets;
		}
	}
}
