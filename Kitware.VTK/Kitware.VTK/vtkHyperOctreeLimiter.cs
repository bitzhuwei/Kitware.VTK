using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkHyperOctreeLimiter : vtkDataSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkHyperOctreeLimiter";

		public new static readonly string MRClassNameKey;

		static vtkHyperOctreeLimiter()
		{
			vtkHyperOctreeLimiter.MRClassNameKey = "class vtkHyperOctreeLimiter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHyperOctreeLimiter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHyperOctreeLimiter"));
		}

		public vtkHyperOctreeLimiter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeLimiter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeLimiter New()
		{
			vtkHyperOctreeLimiter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeLimiter.vtkHyperOctreeLimiter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeLimiter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkHyperOctreeLimiter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkHyperOctreeLimiter.vtkHyperOctreeLimiter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeLimiter_GetMaximumLevel_01(HandleRef pThis);

		public int GetMaximumLevel()
		{
			return vtkHyperOctreeLimiter.vtkHyperOctreeLimiter_GetMaximumLevel_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeLimiter_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkHyperOctreeLimiter.vtkHyperOctreeLimiter_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkHyperOctreeLimiter_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkHyperOctreeLimiter.vtkHyperOctreeLimiter_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeLimiter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkHyperOctreeLimiter NewInstance()
		{
			vtkHyperOctreeLimiter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeLimiter.vtkHyperOctreeLimiter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHyperOctreeLimiter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkHyperOctreeLimiter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkHyperOctreeLimiter SafeDownCast(vtkObjectBase o)
		{
			vtkHyperOctreeLimiter vtkHyperOctreeLimiter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkHyperOctreeLimiter.vtkHyperOctreeLimiter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHyperOctreeLimiter = (vtkHyperOctreeLimiter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHyperOctreeLimiter.Register(null);
				}
			}
			return vtkHyperOctreeLimiter;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkHyperOctreeLimiter_SetMaximumLevel_07(HandleRef pThis, int levels);

		public void SetMaximumLevel(int levels)
		{
			vtkHyperOctreeLimiter.vtkHyperOctreeLimiter_SetMaximumLevel_07(base.GetCppThis(), levels);
		}
	}
}
