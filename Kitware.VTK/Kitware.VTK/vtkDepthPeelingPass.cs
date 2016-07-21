using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDepthPeelingPass : vtkRenderPass
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDepthPeelingPass";

		public new static readonly string MRClassNameKey;

		static vtkDepthPeelingPass()
		{
			vtkDepthPeelingPass.MRClassNameKey = "class vtkDepthPeelingPass";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDepthPeelingPass.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDepthPeelingPass"));
		}

		public vtkDepthPeelingPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDepthPeelingPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDepthPeelingPass New()
		{
			vtkDepthPeelingPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDepthPeelingPass.vtkDepthPeelingPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDepthPeelingPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDepthPeelingPass() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDepthPeelingPass.vtkDepthPeelingPass_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkDepthPeelingPass_GetLastRenderingUsedDepthPeeling_01(HandleRef pThis);

		public virtual bool GetLastRenderingUsedDepthPeeling()
		{
			return vtkDepthPeelingPass.vtkDepthPeelingPass_GetLastRenderingUsedDepthPeeling_01(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDepthPeelingPass_GetMaximumNumberOfPeels_02(HandleRef pThis);

		public virtual int GetMaximumNumberOfPeels()
		{
			return vtkDepthPeelingPass.vtkDepthPeelingPass_GetMaximumNumberOfPeels_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkDepthPeelingPass_GetOcclusionRatio_03(HandleRef pThis);

		public virtual double GetOcclusionRatio()
		{
			return vtkDepthPeelingPass.vtkDepthPeelingPass_GetOcclusionRatio_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkDepthPeelingPass_GetOcclusionRatioMaxValue_04(HandleRef pThis);

		public virtual double GetOcclusionRatioMaxValue()
		{
			return vtkDepthPeelingPass.vtkDepthPeelingPass_GetOcclusionRatioMaxValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern double vtkDepthPeelingPass_GetOcclusionRatioMinValue_05(HandleRef pThis);

		public virtual double GetOcclusionRatioMinValue()
		{
			return vtkDepthPeelingPass.vtkDepthPeelingPass_GetOcclusionRatioMinValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDepthPeelingPass_GetTranslucentPass_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkRenderPass GetTranslucentPass()
		{
			vtkRenderPass vtkRenderPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDepthPeelingPass.vtkDepthPeelingPass_GetTranslucentPass_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderPass = (vtkRenderPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderPass.Register(null);
				}
			}
			return vtkRenderPass;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDepthPeelingPass_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDepthPeelingPass.vtkDepthPeelingPass_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkDepthPeelingPass_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDepthPeelingPass.vtkDepthPeelingPass_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDepthPeelingPass_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDepthPeelingPass NewInstance()
		{
			vtkDepthPeelingPass result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDepthPeelingPass.vtkDepthPeelingPass_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDepthPeelingPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDepthPeelingPass_ReleaseGraphicsResources_11(HandleRef pThis, HandleRef w);

		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkDepthPeelingPass.vtkDepthPeelingPass_ReleaseGraphicsResources_11(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkDepthPeelingPass_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDepthPeelingPass SafeDownCast(vtkObjectBase o)
		{
			vtkDepthPeelingPass vtkDepthPeelingPass = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDepthPeelingPass.vtkDepthPeelingPass_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDepthPeelingPass = (vtkDepthPeelingPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDepthPeelingPass.Register(null);
				}
			}
			return vtkDepthPeelingPass;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDepthPeelingPass_SetMaximumNumberOfPeels_13(HandleRef pThis, int _arg);

		public virtual void SetMaximumNumberOfPeels(int _arg)
		{
			vtkDepthPeelingPass.vtkDepthPeelingPass_SetMaximumNumberOfPeels_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDepthPeelingPass_SetOcclusionRatio_14(HandleRef pThis, double _arg);

		public virtual void SetOcclusionRatio(double _arg)
		{
			vtkDepthPeelingPass.vtkDepthPeelingPass_SetOcclusionRatio_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkDepthPeelingPass_SetTranslucentPass_15(HandleRef pThis, HandleRef translucentPass);

		public virtual void SetTranslucentPass(vtkRenderPass translucentPass)
		{
			vtkDepthPeelingPass.vtkDepthPeelingPass_SetTranslucentPass_15(base.GetCppThis(), (translucentPass == null) ? default(HandleRef) : translucentPass.GetCppThis());
		}
	}
}
