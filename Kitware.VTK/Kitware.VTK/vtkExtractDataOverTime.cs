using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkExtractDataOverTime : vtkPointSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractDataOverTime";

		public new static readonly string MRClassNameKey;

		static vtkExtractDataOverTime()
		{
			vtkExtractDataOverTime.MRClassNameKey = "class vtkExtractDataOverTime";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractDataOverTime.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractDataOverTime"));
		}

		public vtkExtractDataOverTime(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractDataOverTime_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractDataOverTime New()
		{
			vtkExtractDataOverTime result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractDataOverTime.vtkExtractDataOverTime_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractDataOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkExtractDataOverTime() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkExtractDataOverTime.vtkExtractDataOverTime_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractDataOverTime_GetNumberOfTimeSteps_01(HandleRef pThis);

		public virtual int GetNumberOfTimeSteps()
		{
			return vtkExtractDataOverTime.vtkExtractDataOverTime_GetNumberOfTimeSteps_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractDataOverTime_GetPointIndex_02(HandleRef pThis);

		public virtual int GetPointIndex()
		{
			return vtkExtractDataOverTime.vtkExtractDataOverTime_GetPointIndex_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractDataOverTime_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkExtractDataOverTime.vtkExtractDataOverTime_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkExtractDataOverTime_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkExtractDataOverTime.vtkExtractDataOverTime_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractDataOverTime_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkExtractDataOverTime NewInstance()
		{
			vtkExtractDataOverTime result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractDataOverTime.vtkExtractDataOverTime_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractDataOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkExtractDataOverTime_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkExtractDataOverTime SafeDownCast(vtkObjectBase o)
		{
			vtkExtractDataOverTime vtkExtractDataOverTime = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkExtractDataOverTime.vtkExtractDataOverTime_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractDataOverTime = (vtkExtractDataOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractDataOverTime.Register(null);
				}
			}
			return vtkExtractDataOverTime;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkExtractDataOverTime_SetPointIndex_08(HandleRef pThis, int _arg);

		public virtual void SetPointIndex(int _arg)
		{
			vtkExtractDataOverTime.vtkExtractDataOverTime_SetPointIndex_08(base.GetCppThis(), _arg);
		}
	}
}
